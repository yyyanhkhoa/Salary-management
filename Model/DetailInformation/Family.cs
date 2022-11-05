using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Model
{
	public class Family 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(255)]
        public string Id { get; set; } = null!;

        public string EmployeeId { get; set; } = null!;

        [MaxLength(255)]
        public string Name { get; set; } = null!;

        public DateOnly DateOfBirth { get; set; }
        public string Occupation { get; set; } = null!;
        public RelativeType RelativeType { get; set; }


    }
}
