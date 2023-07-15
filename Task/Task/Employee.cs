using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Employee
    {
        [Required]
        public int EmployeeId { get; set; }

        [MinLength(2),MaxLength(25)]
        [Required]
        public string FirstName { get; set; }

        [MinLength(2), MaxLength(25)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [DisplayName("Email")]
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

        [DisplayName("Phone")]
        [Phone]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime BirthDate { get; set; }

    }
}
