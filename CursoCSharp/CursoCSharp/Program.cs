using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundametos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencias de Tipos - Fundamentos", Inferencia.Executar},
                {"Interpolação de string - Fundamentos", InterpolacaoDeString.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados do Console - Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                //Estruturas de Controle
                {"Estrutura if - Estruturas de Controle", EstruturaIf.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Metodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Parametros e Variaveis - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get e Set - Classes e Métodos", GetSet.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"Atributos Readonly - Classes e Métodos", Readonly.Executar},
                {"Enumerações (Enum) - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExempploStruct.Executar},
                {"Struct vs Classe - Classes e Métodos", StructVsClasse.Executar},

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                { "Queue - Coleções", ColecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdade.Executar},
                { "Stack - Coleções", ColecoesStack.Executar},
                { "Dictionary - Coleções", ColecoesDictionary.Executar},

                 //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                { "Encapsulamento - OO", OO.Encapsulamento.Executar},
                { "Polimorfismo - OO", Polimorfismo.Executar},
                { "Abstract - OO", Abstract.Executar},
                { "Interface - OO", Interface.Executar},
                { "Sealed - OO", Sealed.Executar},

                // Métodos & Funções
                { "Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                { "Lambdas Como Delegates - Métodos & Funções", LambdasDelegate.Executar},
                { "Usando Delegates - Métodos & Funções", UsandoDelegates.Executar},
                { "Delegates Como Função Anonima - Métodos & Funções", DelegateFunAnonima.Executar},
                { "Delegates Como Parâmetros - Métodos & Funções", DelegatesComoParametros.Executar},
                { "Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar},

                // Exceções
                { "Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                { "Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                // Api
                { "Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                { "Lendo Arquivos - Usando API", LendoArquivos.Executar},
                { "Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                { "Diretórios - Usando API", Diretorios.Executar},
                { "Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                { "Exemplo Path - Usando API", ExemploPath.Executar},
                { "Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                { "Exemplo Timespan - Usando API", ExemploTimeSpan.Executar},
            }) ;

            central.SelecionarEExecutar();
        }
    }
}