using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Primeirotrabalho;

namespace Primeirotrabalho
{
    class Program    
    {
        static void Main (string[] args)
        {
    
        Aluno aluno = new Aluno();   
        aluno.ExibirNome();
        aluno.ExibirIdade();
        aluno.ExibirRa();
        aluno.ExibirCurso();
    
        }
    }

   
}
 public class Pessoa 
    {
       public  int idade = 22;
       public string nome = "Pedro Henrique Fontes";

       public void ExibirIdade()
       {
        Console.WriteLine("A idade do aluno é: " + idade);
       }   
       public void ExibirNome()
       {
        Console.WriteLine("O nome do aluno é: " + nome);
       }

        }

        public class Aluno : Pessoa 
    { 
        public string ra = "G492ED-0";
        public string curso ="Análise e Desenvolvimento de Sistemas.";
        public void ExibirRa() 
        {
            Console.WriteLine($"O RA do aluno é: " + ra);
        }

        public void ExibirCurso() 
        {
            Console.WriteLine("Aluno faz: "+ curso);
        }
    }
   