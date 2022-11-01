using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model.EmployeeList
{
    internal class EmployeeInTableModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DateOnly Birth { get; set; }

        public string Identity { get; set; }

        public float Allowance { get; set; }

        public EmployeeInTableModel(string id, string name, DateOnly birth, string identity, float allowance)
        {
            Id = id;
            Name = name;
            Birth = birth;
            Identity = identity;
            Allowance = allowance;
        }
    }
}
