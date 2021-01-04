using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace M226B_Streams
{
  class BynaryWriter
  { 
    static void Binary(string[] args)
    {
      string fileName = @"g:\Daten\binaryValues.bin";

      // write process
      try {     
        using (FileStream fileStreamWrite = new FileStream(fileName, FileMode.Create))
        {
          BinaryWriter bw = new BinaryWriter(fileStreamWrite);
          bw.Write(1234);             // int Value
          bw.Write(5.678);            // double value
          bw.Write("Hello friends");  // string value
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

      // read process
      try {
        using (FileStream fileStreamRead = new FileStream(fileName, FileMode.Open, FileAccess.Read))
        {
          BinaryReader br = new BinaryReader(fileStreamRead);
          Console.WriteLine(br.ReadInt32() + "\n" + br.ReadDouble() + "\n" + br.ReadString());
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }

  }
}
