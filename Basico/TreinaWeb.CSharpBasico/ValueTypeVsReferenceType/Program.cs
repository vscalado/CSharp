﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Value-Types são os dados primitivos no .NET, como exemplo numeros inteiros*/
            int numero1 = 3;
            int numero2 = numero1;
            numero1 = 5;
        
            Console.WriteLine("numero1 = {0},numero2 = {1}", numero1, numero2);
            Console.ReadKey();

            //Passagem por referência
            Teste teste1 = new Teste();
            teste1.Quantidade = 3;
            Teste teste2 = teste1;
            teste1.Quantidade = 5;

            Console.WriteLine("teste1.Quantidade = {0},teste2.Quantidade = {1}", teste1.Quantidade, teste2.Quantidade);
            Console.ReadKey();

            teste2.Quantidade = 7;

            Console.WriteLine("teste1.Quantidade = {0},teste2.Quantidade = {1}", teste1.Quantidade, teste2.Quantidade);
            Console.ReadKey();
        }
    }

    class Teste
    {
        public int Quantidade;
    }
}

