using _3.LSP.Entities;
using System;

namespace _3.LSP
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //var produto1 = new GeladeiraViolacao("geladeira", 100);
            //Console.WriteLine(produto1.ObterCaracteristicaProduto(produto1));

            //var produto2 = new GeladeiraLSP("geladeira", 150);
            //Console.WriteLine(produto2.ObterCaracteristicaProduto(produto2));

            //var produto3 = new FogaoLSP("geladeira", 150);
            //Console.WriteLine(produto2.ObterCaracteristicaProduto(produto3));

            var obj1 = new ClassePaiA();
            var obj2 = new ClasseFilhaB();

            Console.WriteLine(ImprimirNome(obj1));
            Console.WriteLine(ImprimirNome(obj2));
        }

        private static string ImprimirNome(ClassePaiA obj)
        {
            return obj.GetNome();
        }
    }
}