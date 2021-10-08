using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace desafio6
{
    class Desafio6
    {
        static void Main(string[] args)
        {
            List<Aluno> aluno = new List<Aluno>();
            aluno.Add(new Aluno { nome = "John Smith", idade = 12, nota = 7 });
            aluno.Add(new Aluno { nome = "Ana Lee", idade = 13, nota = 9 });
            aluno.Add(new Aluno { nome = "Maria Jane", idade = 13, nota = 8 });

            foreach (var estudante in aluno)
            {
                Console.WriteLine((" " + estudante.nome + "\t"));
                Console.WriteLine((" Idade: " + estudante.idade + "\t"));
                Console.WriteLine(" Nota final: " + estudante.nota + "\t" + "\n");
            }

            int[] notas = { 7, 9, 8 };
            int soma = notas.Sum();
            Console.WriteLine(" A Soma das notas: " + soma);

            StringBuilder csvcontent = new StringBuilder();

            csvcontent.AppendLine("Alunos,Idade,Nota");
            csvcontent.AppendLine("Ana Lee, 13,9");
            csvcontent.AppendLine("John Smith,12,7");
            csvcontent.AppendLine("Maria Jane, 13,8");
            csvcontent.AppendLine("Total de notas, ," + soma);

            string csvpath = @"C:\Users\Alan\source\repos\desafio6\Dados.csv";
            File.AppendAllText(csvpath, csvcontent.ToString());

            string csvpath1 = @"C:\Users\Alan\source\repos\desafio6\Ana.csv";
            File.AppendAllText(csvpath1, csvcontent.ToString());

            string csvpath2 = @"C:\Users\Alan\source\repos\desafio6\Maria.csv";
            File.AppendAllText(csvpath2, csvcontent.ToString());

            string csvpath3 = @"C:\Users\Alan\source\repos\desafio6\John.csv";
            File.AppendAllText(csvpath3, csvcontent.ToString());


        }
    }
}
