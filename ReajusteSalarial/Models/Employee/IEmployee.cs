using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial.Models.Employee
{
    internal interface IEmployee
    {
        public string name { get; set; }
        public string role { get; set; }
        public double sallary { get; set; }
        public int year { get; set; }



    }
}
