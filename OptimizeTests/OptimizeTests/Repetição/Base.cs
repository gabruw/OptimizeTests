﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizeTests.Repetição
{
    class Base
    {
        List<BaseClassComander> ListComander = new List<BaseClassComander>()
        {
            new BaseClassComander()
            {
               name = "João",
               cod = 123,
            },
            new BaseClassComander()
            {
                name = "Maria",
                cod = 321,
            },
            new BaseClassComander()
            {
                name = "Neto",
                cod = 161,
            },new BaseClassComander()
            {
                name = "Caco",
                cod = 125,
            },new BaseClassComander()
            {
                name = "Chico",
                cod = 127,
            },new BaseClassComander()
            {
                name = "Temma",
                cod = 111,
            },new BaseClassComander()
            {
                name = "Ariana",
                cod = 90,
            },new BaseClassComander()
            {
                name = "Mariana",
                cod = 1900,
            },new BaseClassComander()
            {
                name = "Niggerson",
                cod = 1313,
            },new BaseClassComander()
            {
                name = "Xurelis",
                cod = 1616,
            },
        };

        public void PrintFor()
        {
            for (var i = 0; i <= ListComander.Count - 1; i++)
            {
                Console.WriteLine("Nome {0}", ListComander[i].name);
                Console.WriteLine("Código {0}", ListComander[i].cod);
            }

            Console.WriteLine("Fim do For");
        }

        public void PrintForeach()
        {
            foreach (var comander in ListComander)
            {
                Console.WriteLine("Nome {0}", comander.name);
                Console.WriteLine("Código {0}", comander.cod);
            }

            Console.WriteLine("Fim do Foreach");
        }

        public void PrintWhile()
        {
            int i = 0;
            while (i <= ListComander.Count - 1)
            {
                Console.WriteLine("Nome {0}", ListComander[i].name);
                Console.WriteLine("Código {0}", ListComander[i].cod);

                i++;
            }

            Console.WriteLine("Fim do While");
        }

        public void PrintLinq()
        {
            ListComander.ForEach(comander => 
            {
                Console.WriteLine("Nome {0}", comander.name);
                Console.WriteLine("Código {0}", comander.cod);
            });

            Console.WriteLine("Fim do Linq");
        }
    }
}
