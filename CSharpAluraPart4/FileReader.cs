using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAluraPart4
{
    public class FileReader : IDisposable
    {
        public string File { get; set; }

        public FileReader(string file)
        {
            //throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + file);
        }

        public string ReadNextLine()
        {
            Console.WriteLine("Lendo linha...");

            throw new IOException();

            return "linha do arquivo";
            
        }
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
