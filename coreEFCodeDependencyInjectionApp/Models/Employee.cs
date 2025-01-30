using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coreEFCodeDependencyInjectionApp.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        [MinLength(8)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Column("EmailAddress")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Range(18, 60)]
        public int Age { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }

        [Precision(14, 2)]
        public decimal Salary { get; set; }
    }
}
