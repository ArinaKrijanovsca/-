using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание___1_3_
{
    internal class Content: Book
    {
        private string contented;

        public string Contented { get; set; }

        public Content(string contented)
        {
            Contented = contented;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Cодержание книги: {Contented}");
        }

    }
}
