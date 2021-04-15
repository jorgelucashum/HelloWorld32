using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld32.Entities;

namespace HelloWorld32
{
    // Polimorfismo:
    // Em POO, polimorfismo é o recurso que permite que variáveis de um mesmo tipo mais genérico possam apontar para objetos de tipos especificos diferemtes, tendo assim comportamentos diferentes conforme cada tipo especifico.
    // A associação do tipo específico com o tipo genérico é feita em tempo de execução(upcasting).
    // O compilador não sabe para qual tipo específico a chamada do método está sendo feita, porque isso só é realizado em tempo de execução.

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); // Instanciando lista vazia.

            Console.Write("Digite a quantidade de empregados: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Empregado #" + i + ":");
                Console.Write("É terceirizado? (s/n): ");
                char choose = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double value = double.Parse(Console.ReadLine());

                // Estrutura condicional para adicionar um objeto na lista de acordo com a entrada.
                if (choose == 's') 
                {
                    Console.Write("Custo adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(name, hours, value, additionalCharge)); // Polimorfismo sendo usado (Lista do tipo 'Employee' suportando o tipo da sua subclasse 'OursourcedEmployee').
                }
                else
                {
                    employees.Add(new Employee(name, hours, value));
                }
            }

            Console.WriteLine("\nPagamentos: ");
            foreach (Employee obj in employees) // Percorrer toda a lista e imprimir o método que resulta no valor final.
            {
                Console.WriteLine("R$ " + obj.Payment().ToString("F2"));
            }

            Console.ReadLine(); // Fim.
        }
    }
}
