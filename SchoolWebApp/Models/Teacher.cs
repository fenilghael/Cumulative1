using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApp.Models
{
    /// <summary>
    /// Represents a teacher in the School database.
    /// </summary>
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }

        [Required]
        [StringLength(100)]
        public string TeacherFname { get; set; }

        [Required]
        [StringLength(100)]
        public string TeacherLname { get; set; }

        [StringLength(50)]
        public string EmployeeNumber { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Salary { get; set; }

        public DateTime? HireDate { get; set; }
    }
}
