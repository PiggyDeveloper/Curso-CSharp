using System;

namespace Seção Fundamentos
{
    class notação
    {
        public static void Executar() {

            /*
             Ela Chama as Funcionalidades da Variavel e Pode Acessar Classes e Metodos Usando Ela
            */

            var saudaçao = "Hey".toUpper().insert(3, "Mundo").replace("Mundo"," World");
                 
            Console.WriteLine(saudaçao);

           /*
           Quando se usa A Notação Quando o Valor da Variavel Está Vazio, Causa Problema

           Navegação Segura > Pode-se Colocar (?) quando o Valor não Estiver Definido
           
           O Simbolo (?) vai perguntar pra variavel se ela está vazia caso esteja ele retorna um valor vazio tirando o erro
           */ 

           var importante = null;

           Console.WriteLine(importante?.Length);



        }
    }
}