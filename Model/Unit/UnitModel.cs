using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model.Unit
{
    internal class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Phone_number { get; set; }
        public DateTime Date_founded { get; set; }

        public Unit(int id, string name, string address, string phone_number, DateTime date_founded)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone_number = phone_number;
            Date_founded = date_founded;
        }
    }
}
