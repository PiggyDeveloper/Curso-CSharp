using System;

namespace Seção Fundamentos
{
    class leituraconsole
    {
     public static void Executar() {

         /*
          Console Read Line lê o dado das Strings do Console

          *Tudo que é Escrito no Console é uma String

          *Para Passar uma String para Inteiro ou Double é usado type.Parse(Console.ReadLine())
          *Aonde Ele Vai Passar o Codigo de String para o Tipo que estiver Selecionando o Atributo
          
          */

         Console.Write("Qual é o seu Nome ?");    
         var nome = Console.ReadLine();

         Console.Write("Qual Sua Idade?");
         int idade = int.Parse(Console.ReadLine());

         Console.Write("Qual Seu Salario?");
         double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

         Console.WriteLine($" Seu Nome {nome} , Sua Idade {idade} , Sua Renda {salario}, Foi Armazenado no Sistema com sucesso!")
           
         CultureInfo.InvariantCulture;  
     }
    }
}