using System;

namespace Seção Fundamentos {

    class inteporlação {

        public static void Executar() {

            var nome = "Notebook Dell";
            var preço = 1000.0;
            var marca = "Dell";

            /* 
            Contatenei String + var é Escrevi no Console
            */

            Console.WriteLine("O " + nome + "da Marca " + marca + "esta pelo preço de " + preço);

            /*
             Interpolação

             Fiz Usando {N} para depois dizer que sera Substituido na Ordem
            */

            Console.WriteLine("O {0} da Marca {1} esta pelo preço de {2}", nome , marca, preço); 

            /*
            Interpolação

            Fiz Usando $ antes da String e coloquei {string}
            */

            Console.WriteLine($"A Marca {marca} é uma Boa Marca, Principalmente o Notebook {nome} que esta pelo preço de apenas {preço}");
        }
        
    }
    
}