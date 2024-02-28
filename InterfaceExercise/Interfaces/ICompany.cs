using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Interfaces
{
    public interface ICompany
    {
        public string Logo { get; set; }
        public bool HasCommissionEmployees { get; set; }
    }
}
