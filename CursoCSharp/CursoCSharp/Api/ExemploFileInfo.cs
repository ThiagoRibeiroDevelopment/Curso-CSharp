using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploFileInfo
    {
        //Usar params pra passar quantos parametros quiser pro Array
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);//Retorna o nome do arquivo com o tipo da extensao
            Console.WriteLine(origem.IsReadOnly); //IsReadOnly pergunta: Eh apenas leitura?
            Console.WriteLine(origem.FullName);  //Retorna o nome completo do caminho
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.DirectoryName);//Retorna diretorio do caminho sem o nome do arquivo

            //Copiar o caminho de orgigem  para caminho copia
            origem.CopyTo(caminhoCopia);
            //Mover o caminho de origem para o caminho de destino
            origem.MoveTo(caminhoDestino);
        }
    }
}
