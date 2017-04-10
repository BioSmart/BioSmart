using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using SIMOCModel.Enum;
using SIMOCModel.Events;

namespace SIMOCComm
{
    public class AsynchronousSocketListener
    {
        public AsynchronousSocketListener(int serverPort, int messageSize, char startOfMessage, char endOfMessage)
        {
            ServerPort = serverPort;
            MessageSize = messageSize;
            MessageStart = startOfMessage;
            MessageEnd = endOfMessage;

            ChecksumPosition = MessageSize - 2;
        }

        #region Properties

        public bool ListenerEnabled { get; set; }

        public bool Connected { get; private set; }

        public int ServerPort { get; set; }

        public int MessageSize { get; set; }

        public char MessageStart { get; set; }

        public char MessageEnd { get; set; }

        public int ChecksumPosition { get; set; }

        public Socket Listener { get; set; }

        #endregion

        #region Events

        public event EventHandler OnConnect;
        public event EventHandler OnDisconnect;
        public event EventHandler<ReadEventArgs> OnRead;
        public event EventHandler<ErrorEventArgs> OnError;

        #endregion

        #region Operations

        public void StartListening()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());

            IPAddress ipAddress = null;
            foreach (var ip in ipHostInfo.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = ip;
                }
            }

            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, ServerPort);

            Listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            Listener.Bind(localEndPoint);
            Listener.Listen(1);

            ListenerEnabled = true;

            Thread t = new Thread(Listening);
            t.Start();
        }

        public void StopListening()
        {
            ListenerEnabled = false;
        }

        private void Listening()
        {
            Socket handler = null;

            try
            {
                handler = Listener.Accept();

                if (!Connected)
                {
                    OnConnect?.Invoke(this, null);
                    Connected = true;
                }

                while (ListenerEnabled)
                {
                    byte[] buffer = new byte[MessageSize];

                    int bytesRead = handler.Receive(buffer, 0, MessageSize, 0);

                    ReadBytes(bytesRead, buffer);
                }
            }
            catch (Exception e)
            {
                OnError?.Invoke(this, new ErrorEventArgs(ErrorType.Generic, e));
            }
            finally
            {
                if (handler != null)
                {
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();

                    Listener.Close();
                }

                if (Connected)
                {
                    OnDisconnect?.Invoke(this, null);
                    Connected = false;
                }
            }
        }

        #endregion

        #region Send

        private void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        #endregion

        #region Helpers

        private void ReadBytes(int bytesRead, byte[] content)
        {
            if (bytesRead > 0)
            {
                // Check the integrity of the message
                if (content[0] == MessageStart)
                {
                    if (content[content.Length - 1] == MessageEnd)
                    {
                        if (Checksum(content, ChecksumPosition))
                        {
                            OnRead?.Invoke(this, new ReadEventArgs(bytesRead, content));
                        }
                        else
                        {
                            OnError?.Invoke(this, new ErrorEventArgs(ErrorType.InvalidChecksum,
                                string.Format("Invalid checksum. Received: {0}", SIMOCModel.Helpers.ByteArray.ToString(content))));
                        }
                    }
                    else
                    {
                        OnError?.Invoke(this, new ErrorEventArgs(ErrorType.InvalidEndOfMessage,
                                string.Format("Invalid end of message. Expected: {0}. Received: {1}", (byte)MessageEnd, content[content.Length - 1])));
                    }
                }
                else
                {
                    OnError?.Invoke(this, new ErrorEventArgs(ErrorType.InvalidStartOfMessage,
                                string.Format("Invalid start of message. Expected: {0}. Received: {1}", (byte)MessageStart, content[0])));
                }
            }
            else
            {
                OnError?.Invoke(this, new ErrorEventArgs(ErrorType.EmptyMessag,
                                string.Format("The message was empty. Received: {0}", SIMOCModel.Helpers.ByteArray.ToString(content))));
            }
        }

        private static bool Checksum(byte[] content, int checksumPosition)
        {
            byte sum = 0;

            if (checksumPosition <= 0)
            {
                return false;
            }

            for (int i = 0; i < checksumPosition; i++)
            {
                sum += content[i];
            }

            return sum == content[checksumPosition];
        }

        #endregion
    }
}
