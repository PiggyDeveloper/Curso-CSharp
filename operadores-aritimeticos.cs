using System;

namespace Seção Fundamentos
{
    class operadores_aritimeticos
    {
        public static void Executar() {

            /*
             Operadores:' *  -  +  /  %'

             % = Modulo (Resto)

             * = Vezes

             - = Subtração

             + = Soma

             / = Divisão

             MathPow - Primeiro a Base Depois o Expoente

            */

           var preço = 1000;
           var imposto = 355;
           var desconto = 1.1;

           var total = preço + imposto;
           var totaldescontado = total - (total * desconto);

           Console.WriteLine($"O Preço Final é {totaldescontado}");

           //IMC

           var peso = 97.2;
           var altura = 1.72;
           var IMC = peso / Math.Pow(altura, 2);

           Console.Write($"O IMC Brasileiro é {IMC}");

        }
        
    }
    
}