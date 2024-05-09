using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание___1_3_
{
    internal class Title :Book
    {
        private string name;
        public string Name { get; set; }

        public Title()
        {
        }

        public Title(string name)
        {
            Name = name;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Название книги:{Name}");
        }

    }
}
