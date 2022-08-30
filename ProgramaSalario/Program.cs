using System;
using System.Globalization;

namespace ProgramaSalario
{
    class Program
    {

        static void Main(string[] args)
        {
        Empresa e = new Empresa();//Instaciamento 

            Console.WriteLine("Qual nome da sua empresa:");
            e.Nome = Console.ReadLine();
            Console.WriteLine("Qual cargo voce deseja acessa?");//Verificar uma logica com o ESCOLHA/SWITCH
            e.Cargo = Console.ReadLine();
            Console.WriteLine($"Quantos funcionarios exerce o cargo de {e.Cargo} sua empresa tem?");
            e.Funcionarios = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual salario a empresa paga pra quem exerce este cargo");
            e.Salarios = double.Parse(Console.ReadLine());

            //dados
            Console.WriteLine("DADOS DA EMPRESA " + e);
            Console.WriteLine();
            Console.WriteLine("Quantos funcionarios voce deseja contratar?");
            int func = int.Parse(Console.ReadLine());
            e.ContratarFuncionarios(func);
            Console.WriteLine();
            Console.WriteLine("DADOS ATUALIZADOS " + e);
            Console.WriteLine();
            Console.WriteLine("Quanto funcionarios voce deseja demitir?");
            int dem = int.Parse(Console.ReadLine());
            e.DemitirFuncionarios(dem);
            Console.WriteLine("DADOS ATUALIZADOS " + e);




        }
    }
}
