using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial.Models.Employee
{
    internal class EmployeeOld : Employee
    {
        public List<Employee> lista  { get; set; }
        public EmployeeOld()
        {
            this.Roll = "Old";
            this.lista = new List<Employee>();

        }

    }
}
