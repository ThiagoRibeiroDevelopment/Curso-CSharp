using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            //ToUpper deixa as letras em maisculas, insert insere um conjunto de carcateres um posicao se definir
            //Replace troca um caminho ou caractes por outros
            var saudacao = "Olá ".ToUpper().Insert(4, "Word!").Replace("Word!", "Mundo");
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //O ? é usado para uma navegação segura,
            //onde nesse caso o método Length só será executado se valorImportante estiver ok, que é o motivo do console acima nao dar erro
            
        }
    }
}
