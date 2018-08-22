using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Column("FirstName")]
        [Display(Name ="First Name")]
        [StringLength(50, ErrorMessage = "First name connot longer than 50 characters.")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Enrollment date")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime EnrollmentDate { get; set; }
        [Display (Name ="Full Name")]
        public string FullName
        {
            get { return this.LastName + " " + this.FirstMidName; }
        }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
