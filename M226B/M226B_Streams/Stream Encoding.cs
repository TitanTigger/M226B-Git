using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace M226B_Streams
{
    public class Stream_Encoding
    {

        public void OpenFile()
        {
            var fileName = @"C:\Users\maxbr\OneDrive\Desktop\M226B\M226B Git\Encoding File.txt";

            using (FileStream fs = File.OpenRead(fileName))
            using (var sr = new StreamReader(fs))
            {
                string encoding = sr.CurrentEncoding.ToString();
                string content = sr.ReadToEnd();

                var bytes = System.Text.Encoding.UTF8.GetBytes(content);
                string Base64 = System.Convert.ToBase64String(bytes);
                Console.WriteLine(Base64);
                Console.ReadLine();
            }
           
        }

    }

}
