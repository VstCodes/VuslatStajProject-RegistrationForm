using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuslatProject.Models.RegistrationInfo
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [ForeignKey(nameof(Department.Id))]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
