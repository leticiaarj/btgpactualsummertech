using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            ler a = new ler();
            var retorno = a.test();

            val b = new val();

            b.validar(a.test());
            Console.ReadKey();
        }
    }

}
