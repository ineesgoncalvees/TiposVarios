using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios {
    class Program {
        static void Main(string[] args) {
            string a = "kjhgfd";
            string b = "jhgfd";
            string c = "\u2605";
            string d = @"""werthyjhtgref""";
            string e = @"\\u2344";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            int x = 3;

            string f = "edfgfh" + 32;
            string g = $"x = {x}";
            string h = $@"O valor de x é {x}";

            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
        }
    }
}
