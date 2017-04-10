using System.Text;

namespace SIMOCModel.Helpers
{
    public static class ByteArray
    {
        /// <summary>
        /// Gets a string representation of a byte[]
        /// </summary>
        /// <returns>Byte array as string</returns>
        public static string ToString(byte[] content)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');

            if (content != null)
            {
                for (int i = 0; i < content.Length; i++)
                {
                    sb.Append(content[i]);

                    if (i < content.Length - 1)
                    {
                        sb.Append(',');
                        sb.Append(' ');
                    }
                }
            }

            sb.Append(']');
            return sb.ToString();
        }
    }
}
