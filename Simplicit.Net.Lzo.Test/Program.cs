using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simplicit.Net.Lzo;

namespace Simplicit.Net.Lzo.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            LZOCompressor comp = new LZOCompressor();
            byte[] input = File.ReadAllBytes(@"C:\Users\WHC\Desktop\rubbish\1.bin");
            int decompressLen = 0x15D6;
            byte[] output = comp.DecompressRaw(input, decompressLen);
            Console.WriteLine(output.Length);
            string strResult = Encoding.GetEncoding(936).GetString(output);
            Console.WriteLine(strResult);
            Console.ReadKey();
        }
    }
}
