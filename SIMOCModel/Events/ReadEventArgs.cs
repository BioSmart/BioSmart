using System;

namespace SIMOCModel.Events
{
    public class ReadEventArgs : EventArgs
    {
        public ReadEventArgs(int bytesRead, byte[] content)
        {
            BytesRead = bytesRead;
            Content = content;
        }

        public int BytesRead { get; set; }

        public byte[] Content { get; set; }
    }
}
