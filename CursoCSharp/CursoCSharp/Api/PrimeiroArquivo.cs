using System;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            //A expressao abaixo verifica se a plataforma é Linux, Mac ou Windows,
            //Se for Windows retorna o caminho C: que coloquei "C:/Users/thiag/source""
            //Abaixo usou um operador ternario: se "Home" é um Unix ou MacOSX, senao eh windows, e retorna
            //o caminho que passei do disco C
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("C:/Users/thiag/source");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar()
        {
            //Abaixo, usei o ~ para dizer que é usar o caminho home antes definido na classe ExtensaoString
            //mas se eu nao quisse-se usar o metodo ParseHome da classe ExtensaoString
            //eu poderia ter passado o caminho direto pra variavel path, ficaria:
            // @"C:/Users/thiag/source/primeiro_arquivo.txt", (nao pode esquecer do @)
            //E nao preciria passar o ParseHome abaixo
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                // CreateText cria ou abre um arquivo para escrever texto codificado em UTF - 8.
                // Se o arquivo já existir, seu conteúdo é sobrescrito.
                using (StreamWriter sw = File.CreateText(path)) //StreamWriter eh um escritor, 
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) //AppendText acrescenta texto
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
