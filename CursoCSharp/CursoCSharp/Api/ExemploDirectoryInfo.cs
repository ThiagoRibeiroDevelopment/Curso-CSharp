using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/repos/CursoCSharp/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos ================");
            //GetFiles retorna os arquivos das infomrçãoes em DirectoryInfo declarado acima em dirInfo
            var arquivos = dirInfo.GetFiles(); 
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n== Diretórios ================");
            //GetDirectories retorna as pastas das infomrçãoes em DirectoryInfo declarado acima em dirInfo
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName); //Caminho completo
            Console.WriteLine(dirInfo.Root); //retorna a rais de onde esta (C: ou D:)
            //Parente mostra Pasta pai, se for colocando varios chega ate no root(raiz)
            Console.WriteLine(dirInfo.Parent.Parent); 
        }
    }
}
