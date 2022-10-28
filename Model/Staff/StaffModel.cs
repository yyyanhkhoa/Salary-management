using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model.Staff
{
    internal class Staff
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime Birth { get; set; }

        public string Ethnic { get; set; }

        public string Address { get; set; }

        public int Identity_card_number { get; set; }
        public string Image { get; set; }

        public float Coefficient_allowance { get; set; }

        public Staff(string id, string name, bool gender, DateTime birth, string ethnic, string address, int identity_card_number, string image, float coefficient_allowance)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Birth = birth;
            Ethnic = ethnic;
            Address = address;
            Identity_card_number = identity_card_number;
            Image = image;
            Coefficient_allowance = coefficient_allowance;
        }
    }
}
