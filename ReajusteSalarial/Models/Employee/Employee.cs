using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReajusteSalarial.Models.Employee
{
    internal class Employee : IEmployee
    {

        public Employee()
        {
            
        }
        public Employee(string name, double sallary, int year, string role)
        {
            this.name = name;
            this.sallary = sallary;
            this.year = year;
            this.role = role;
        }

        public string role { get; set; }
        public double sallary { get; set; }
        public string name { get; set; }
        public int year { get; set; }

    }
}

   
