using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine(Path.GetExtension(arquivo));//Passa a extensao do arquivo
            Console.WriteLine(Path.GetFileName(arquivo));//Passa o nome do arquivo
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));//Passa o nome do arquivo sem a extensão
            Console.WriteLine(Path.GetDirectoryName(arquivo));//Passa o diretorio onde esta o arquivo
            Console.WriteLine(Path.HasExtension(arquivo)); //Diz se tem extensão

            Console.WriteLine(Path.HasExtension(pasta)); 
            Console.WriteLine(Path.GetFullPath(pasta)); //retorna o caminho completo da pasta
            Console.WriteLine(Path.GetPathRoot(pasta)); //retorna em que raiz esta a pasta
        }
    }
}
