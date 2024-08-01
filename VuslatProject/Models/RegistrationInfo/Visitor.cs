using System.ComponentModel.DataAnnotations;

namespace VuslatProject.Models.RegistrationInfo
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string VisitorName { get; set; }

        [Required]
        public string VisitorSurname { get; set; }

        [Required]
        [Phone]
        public string VisitorPhoneNum { get; set; }

        [Required]
        [EmailAddress]
        public string VisitorEmail { get; set; }

        [Required]
        public int SelectedDepartmentId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public string Purpose { get; set; }

    }
}
