using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial.Models.Employee
{
    internal interface IEmployee
    {
        public string Name { get; set; }
        public string Roll { get; set; }
        public double Salary { get; set; }
        public int year { get; set; }



    }
}
