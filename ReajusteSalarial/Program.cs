using ReajusteSalarial.Models.Employee;
using System;
using System.Globalization;

public class Program
{
    static void Main(string[] args)
    {
        Employee calculateSallary = new Employee();
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
                    Console.Clear();

                    if (2022 - newEmployee.year >= 3)
                    {
                        Console.WriteLine("Funcionário cadastrado com sucesso!");
                        Console.WriteLine("Funcionário com +3 anos de empresa.");
                        Console.Clear();
  
                        employees.Add(newEmployee);
                        oldEmployees.lista.Add(new EmployeeOld()
                        {
                            name = newEmployee.name,
                            sallary = newEmployee.sallary,
                            year =newEmployee.year,
                            role = newEmployee.role
                        });

                    }
                    else if ((2022 - newEmployee.year <= 3) && (2022 - newEmployee.year >= 0))
                    {
                        Console.WriteLine("Funcionário com menos de 3 anos de empresa.");
                        employees.Add(newEmployee);
                    }

                    if (newEmployee.sallary > 7000 && (2022 - newEmployee.year) >= 3)
                    {

                        newEmployee.sallary = calculateSallary.SallaryAdjustment(newEmployee.sallary, 10);
                        Console.WriteLine("Funcionário cadastrado com sucesso!");
                        Console.WriteLine("O funcionário irá receber um aumento de 10%");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Novo salário do funcionário: R$ {newEmployee.sallary:F2}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Funcionário cadastrado com sucesso!");
                        Console.WriteLine("Reajuste de 10% não é válido! Digite a porcentagem de aumento desejada:");
                        double adjustmentValue = double.Parse(Console.ReadLine());
                        newEmployee.sallary = calculateSallary.SallaryAdjustment(newEmployee.sallary, adjustmentValue);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Novo salário do funcionário: R$ {newEmployee.sallary:F2}");
                        Console.ResetColor();
                    }
                     
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

