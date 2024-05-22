using Composite.Composite;
using Composite.Leaf;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Organizacao organizacao = new Organizacao { Nome = "UCB" };

            Organizacao departamentoTI = new Organizacao { Nome = " TI " };
            departamentoTI.Add(new Funcionario { Id = 1001, Nome = "Lucas", Horas = 8 });
            departamentoTI.Add(new Funcionario { Id = 1002, Nome = "Miguel", Horas = 6 });
            departamentoTI.Add(new Funcionario { Id = 1005, Nome = "Maria", Horas = 8 });

            Organizacao departamentoSecretaria = new Organizacao { Nome = " Secretaria " };
            departamentoSecretaria.Add(new Funcionario { Id = 1003, Nome = "Beatriz", Horas = 7 });
            departamentoSecretaria.Add(new Funcionario { Id = 1004, Nome = "Paulo", Horas = 5 });

            organizacao.Add(departamentoTI);
            organizacao.Add(departamentoSecretaria);
            organizacao.GetHoraTrabalhada();

            Console.ReadKey();
        }
    }
}
