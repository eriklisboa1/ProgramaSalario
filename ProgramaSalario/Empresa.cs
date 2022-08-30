using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProgramaSalario
{
    class Empresa
    {
        public string Nome;
        public string Cargo;
        public int Funcionarios;
        public double Salarios;

        public double ReceitaTotal()
        {
            return Funcionarios * Salarios;
        }
        public void ContratarFuncionarios(int funcionarios)
        {
            Funcionarios += funcionarios;
        }
        public void DemitirFuncionarios(int funcionarios)
        {
            Funcionarios -= funcionarios;
        }
        
        public override string ToString()// aqui vai estar o que vai conter em P
        {
            return $" A empresa {Nome} deseja acessa o cargo: {Cargo}\n " +
                $" Quantidade funcionarios:{Funcionarios}\n " +
                $"salario: {Salarios}\n " +
                $"Receita total da empresa :" + ReceitaTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }

 
}
