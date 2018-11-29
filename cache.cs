using System;

namespace Seção Fundamentos
{
    class cache
    {
        public static void Executar() {

            /*
            Cache: Processo de Falar Explicitamente que se quer Converter um Arquivo Quebrado por Exemplo 
            Double -> int

            Pode Gerar Perda de Informação

            (int) = Cache

            */

            double nota = 9.7;
            int Media = (int) nota;

            Console.Write("Qual sua Idade?");

            var idade = Console.ReadLine();
            var idadeToda = int.Parse(idade);

            Console.WriteLine($"Sua Idade é {idade}");

            Console.Write("Digite um Numero");

            /*
            TryParse Tenta Transferir de String Para Número e se Não der Retorna o Valor 0

            Poderia Trocar o Console.ReadLine() por uma var com o mesmo valor
            
            */

            int.TryParse(Console.ReadLine(), out int numero);

            Console.WriteLine($"Seu Numero é {numero}")

            
        }
        
    }
    
}