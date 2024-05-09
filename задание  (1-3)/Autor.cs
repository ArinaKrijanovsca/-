using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание___1_3_
{
    internal class Autor:Book
    {
        public string Author { get; set; }

        public Autor()
        {
        }

        public Autor(string autor)
        {

            Author = autor;

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Автор: {Author}");
        }
    }
}
