using System;

namespace M226B_Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stream_Encoding encode = new Stream_Encoding();
            //encode.OpenFile();

            Objekte_In_File_Speichern fileSpeichern = new Objekte_In_File_Speichern();
            fileSpeichern.ObjektSpeichern();
        }
    }
}
