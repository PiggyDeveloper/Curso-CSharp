using System;
 
 namespace Seção Fundamentos {

     class variaveis_constantes{
     
      public static void Main(String[] args) {

           /*
            Variaveis de Valor Quebrado: Não se Pode usar a Conotação (,) 
            é apenas usado (.) porque esta na linguagem Americana 
           */

           /*
            Constantes: Usado para definir uma Variavel que não pode ser mutada.
            ou seja ela vai continuar com o valor que adquiriu até o final do codigo

            */



            /*
            Tipos de Variaveis Internos >>
            */



            // Bool - Variavel que Verifica se é Verdade ou Mentira Aquele Fato (True,False)

            bool Verdade = true;


            /*  
            Armazenam Numeros Inteiros sem Sinal
            */ 

           uint populacaoBrasileira = 207_600_000;
           ulong populacaoMundial = 7_600_000_000;
           byte idade = 45;

           /*
            Armazenam Numeros Não Quebrados Com Sinal de Negaitvo e Positivo
           */

           int dinheiro = short.MaxValue;
           
           long menorValorLong = long.MinValue; 

           decimal distancia = decimal.MaxValue;

           sbyte saldo = sbyte.MinValue;

           /* 
            Armazena Valores Quebrados
           */

           double nota = 7.5;
           float notatruncada = 7.5F;


          /* 
          Armazenam Sentenças de Caracteres
          
          String: Armazena Sequencias de Palavras em " "
          Char: Armazena uma Letra em ' '

          */

          string Texto = "";

          char letra = 'b'; 


          

      }
          
     }
     
 }