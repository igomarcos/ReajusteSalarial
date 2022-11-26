using ReajusteSalarial.Models.Employee;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        EmployeeOld oldEmployees = new EmployeeOld();

        while (true)
        {
            string option;
            
            Console.WriteLine("============== AJUSTE SALARIAL ==============");
            Console.WriteLine("Digite uma Opção");
            Console.WriteLine("1 - Cadastrar Novo Funcionário");
            Console.WriteLine("2 - Consultar Funcionarios");
            Console.WriteLine("3 - Sair");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Employee newEmployee = new Employee();
                    
                    Console.WriteLine("Digite o nome do funcionário:");
                    newEmployee.name = Console.ReadLine();
                    Console.WriteLine("Digite o cargo do funcionário:");
                    newEmployee.role = Console.ReadLine();
                    Console.WriteLine("Digite o salário do funcionário:");
                    newEmployee.sallary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o ano de contratação do funcionário:");
                    newEmployee.year = Convert.ToInt32(Console.ReadLine());

                    if (newEmployee.year < 2023)
                    {
                        employees.Add(newEmployee);
                        oldEmployees.lista.Add(new EmployeeOld()
                        {
                            name = newEmployee.name,
                            sallary = newEmployee.sallary,
                            year =newEmployee.year,
                            role = newEmployee.role
                        });
                    }
                    else
                    {
                        employees.Add(newEmployee);
                    }

                    Console.WriteLine("funcionário cadastrado com sucesso!");


                    break;
                case "2":
                    foreach (var item in employees)
                    {
                        Console.WriteLine("Nome: " + item.name);
                        Console.WriteLine("Salário: " + item.sallary);
                        Console.WriteLine("Ano de contratação: " + item.year);
                        Console.WriteLine("Cargo: " + item.role);
                        Console.WriteLine("===========================================");
                    }

                    foreach (var item in oldEmployees.lista)
                    {
                        Console.WriteLine("==================== FUNCIONÁRIOS ANTIGOS =======================");
                        Console.WriteLine("Nome: " + item.name);
                        Console.WriteLine("Salário: " + item.sallary);
                        Console.WriteLine("Ano de contratação: " + item.year);
                        Console.WriteLine("Cargo: " + item.role);
                        Console.WriteLine("===========================================");
                    }

                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }      
    }
}