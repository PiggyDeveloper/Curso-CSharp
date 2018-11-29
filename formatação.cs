using System;

namespace Seção Fundamentos
{
    class formatação
      {
        public static void Executar() {
            
           var valor = 15.175;

           


          /*
				   Tipos de Formatação de Casa Decimal 

           F1 = 1 Casa Decimal

           P = Percentual

           C = Current Coin (Moeda Monetaria)

           # = Tipo de Casas Definidas

           D = Define o Numero de Casas que vai ficar o Numero no Inteiro, Adciona Zeros na Frente
 				 */


			    Console.ReadLine(valor.toString("F1"));
          Console.ReadLine(valor.toString("C"));
          Console.ReadLine(valor.toString("P"));
          Console.ReadLine(valor.toString("#.###"));
          
          /*

          Seleciono o Tipo da Moeda (Cultura)

          */

          CultureInfo cultura = new CultureInfo("pt-BR");

          /*
           Defini Que A Linha do Console Sera Lida em Moeda na Cultura Setada ("pt-BR")
          */   

          Console.ReadLine(valor.toString("C", cultura));

          int Inteirar = 150;

          Console.WriteLine(inteirar.toString("D2"));

           
     } 
	}
}