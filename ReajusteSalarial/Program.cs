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
                    Employee novofunc = new Employee();
                    
                    Console.WriteLine("Digite o nome do funcionário:");
                    novofunc.Name = Console.ReadLine();
                    Console.WriteLine("Digite o salário do funcionário:");
                    novofunc.Salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o ano de contratação do funcionário:");
                    novofunc.year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o cargo do funcionário:");
                    novofunc.Roll = Console.ReadLine();

                    if (novofunc.year < 2023)
                    {
                        employees.Add(novofunc);
                        oldEmployees.lista.Add(new EmployeeOld()
                        {
                            Name = novofunc.Name,
                            Salary = novofunc.Salary,
                            year = novofunc.year,
                            Roll = novofunc.Roll
                        });
                    }
                    else
                    {
                        employees.Add(novofunc);
                    }

                    Console.WriteLine("funcionário cadastrado com sucesso!");


                    break;
                case "2":
                    foreach (var item in employees)
                    {
                        Console.WriteLine("Nome: " + item.Name);
                        Console.WriteLine("Salário: " + item.Salary);
                        Console.WriteLine("Ano de contratação: " + item.year);
                        Console.WriteLine("Cargo: " + item.Roll);
                        Console.WriteLine("===========================================");
                    }

                    foreach (var item in oldEmployees.lista)
                    {
                        Console.WriteLine("==================== FUNCIONÁRIOS ANTIGOS =======================");
                        Console.WriteLine("Nome: " + item.Name);
                        Console.WriteLine("Salário: " + item.Salary);
                        Console.WriteLine("Ano de contratação: " + item.year);
                        Console.WriteLine("Cargo: " + item.Roll);
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