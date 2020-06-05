using System;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/repos/CursoCSharp/CursoCSharp".ParseHome();


            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas ================");
            var pastas = Directory.GetDirectories(dirProjeto); //GetDirectories so pega as pastas
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== Arquivos ================");
            var arquivos = Directory.GetFiles(dirProjeto);//GetFiles so pega os arquivos
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n== Raiz ================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir)); //Root mostra o diretorio raiz (C: ou D: por exemplo)

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
