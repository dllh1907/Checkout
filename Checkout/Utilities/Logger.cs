using System.IO;

namespace Checkout.Utilities
{
    public class Logger : ILogger
    {
        public string filePath = @"D:\CheckoutLog.txt";
        public void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}