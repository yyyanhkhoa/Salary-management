using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OfficeOpenXml.Attributes;

namespace Salary_management.Infrastructure.Entities
{
	public class Position
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[MaxLength(255)]
		public string Id { get; set; } = null!;

		[MaxLength(255)]
		public string Name { get; set; } = null!;

		public int BaseSalary { get; set; }

		public int RankId { get; set; }

		public string? Description { get; set; } 

		[EpplusIgnore]
		public Rank Rank { get; set; } = null!;
	}
}