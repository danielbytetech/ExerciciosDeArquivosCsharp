using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ExerciciosDeArquivosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /*Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), 
             * serializa essas informações em formato JSON e salva em um arquivo.*/

            //var pessoa = new Pessoa();
            //Console.Write("Digite o nome: ");
            //pessoa.Nome = Console.ReadLine();
            //Console.Write("Digite a Idade: ");
            //pessoa.Idade = int.Parse(Console.ReadLine());
            //Console.Write("Digite o Email: ");
            //pessoa.Email = Console.ReadLine();

            //var json = JsonSerializer.Serialize(pessoa);

            //string nomeDoArquivo = $"pessoa.json";

            //File.WriteAllText(nomeDoArquivo, json);

            //Console.WriteLine($"Arquivo json salvo com sucesso! " +
            //    $"{Path.GetFullPath(nomeDoArquivo)}");
            #endregion

            #region Exercicio 2
            /*Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.*/

            //string fileName = $"pessoa.json";

            //if (File.Exists(fileName))
            //{
            //    string jsonString = File.ReadAllText(fileName);

            //    Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

            //    Console.WriteLine($"Nome: {pessoa.Nome}");
            //    Console.WriteLine($"Idade: {pessoa.Idade}");
            //    Console.WriteLine($"Email: {pessoa.Email}");
            //}
            //else
            //{
            //    Console.WriteLine($"O arquivo {fileName} não existe.");
            //}
            #endregion

            #region Exercicio 3
            /*Criar um programa que permite ao usuário inserir informações de várias pessoas, 
             * armazena essas informações em uma lista, serializa a lista em formato JSON e salva em um arquivo.*/
            //List<Pessoa> pessoas = new List<Pessoa>();

            //while (true)
            //{
            //    Pessoa pessoa = new Pessoa();
            //    Console.Write("Digite o nome (ou 'sair' para encerrar: ");
            //    string nome = Console.ReadLine();

            //    if (nome.ToLower() == "sair")
            //        break;

            //    pessoa.Nome = nome;

            //    Console.Write("Digite a Idade: ");
            //    int idade = int.Parse(Console.ReadLine());

            //    pessoa.Idade = idade;

            //    Console.Write("Digite o Email: ");
            //    string email = Console.ReadLine();

            //    pessoa.Email = email;

            //    pessoas.Add(pessoa);
            //    Console.Clear();
            //}

            //string json = JsonSerializer.Serialize(pessoas);

            //string fileName = $"Lista-de-pessoas.json";

            //File.WriteAllText(fileName, json);

            //Console.WriteLine($"\nArquivo salvo com sucesso!!");
            #endregion

            #region Exercicio 4
            /*Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.*/

            //string fileName = $"Lista-de-pessoas.json";

            ////Saber se ele existe
            //if (File.Exists(fileName))
            //{
            //    // Ler o arquivo inteiro
            //    string jsonString = File.ReadAllText(fileName);

            //    var listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

            //    foreach(var pessoa in listaPessoas)
            //    {
            //        Console.WriteLine($"Nome: {pessoa.Nome}");
            //        Console.WriteLine($"Idade: {pessoa.Idade}");
            //        Console.WriteLine($"Email: {pessoa.Email}");
            //        Console.WriteLine();
            //    }

            //}
            //else
            //{
            //    Console.WriteLine($"O Arquivo {fileName} não foi encontrado.");
            //}
            #endregion

            #region Exercicio 5
            /*Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, 
             * permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.*/

            //string fileName = "Lista-de-pessoas.json";

            //if (File.Exists(fileName))
            //{
            //    // Ler conteúdo do arquivo JSON
            //    string jsonString = File.ReadAllText(fileName);

            //    // Desserializar JSON para lista de pessoas
            //    List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

            //    // Permitir ao usuário inserir uma idade
            //    Console.WriteLine("Digite a idade para buscar pessoas: ");
            //    int idadeParaBuscar = int.Parse(Console.ReadLine());

            //    // Filtrar a idade da pessoa especificada
            //    List<Pessoa> pessoaComIdade = pessoas.Where(p => p.Idade == idadeParaBuscar).ToList();

            //    if (pessoaComIdade.Any())
            //    {
            //        // Exibir as informações das pessoas com a idade especificada
            //        Console.WriteLine($"Pessoas com {idadeParaBuscar} anos: ");

            //        foreach(var pessoa in pessoaComIdade)
            //        {
            //            Console.WriteLine($"Nome: {pessoa.Nome}, Email: {pessoa.Email}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Nenhuma pessoa foi encontrada com {idadeParaBuscar} anos.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"O arquivo {fileName} não foi encontrado.");
            //}
            #endregion
        }
    }
}
