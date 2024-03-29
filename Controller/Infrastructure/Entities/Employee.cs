﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeOpenXml.Attributes;
using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management.Infrastructure.Entities
{
	public class Employee
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[MaxLength(255)]
		public string Id { get; set; } = null!;

		[MaxLength(255)]
		public string Name { get; set; } = null!;

		public Gender Gender { get; set; }
		public DateOnly DateOfBirth { get; set; }

		[MaxLength(255)]
		public string Ethnic { get; set; } = null!;

		public DateOnly StartDate { get; set; }

		[MaxLength(255)]
		public string Address { get; set; } = null!;

		[MaxLength(12)]
		public string IdentityCardNumber { get; set; } = null!;

		[EpplusIgnore]
		public byte[]? Image { get; set; }

		public float CoefficientAllowance { get; set; }

		public DateTime DateCreated { get; set; }

		List<RewardOrDiscipline> RewardOrDisciplines { get; set; }
		List<Family> Families { get; set; }
		List<UnionHistory> UnionHistories { get; set; }
		List<EmployeeQualification> EmployeeQualifications { get; set; }
		List<UnitHistory> UnitHistories { get; set; }
		List<UnitHistory> PositionHistories { get; set; }
	}
}
