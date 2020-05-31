using System;
using System.ComponentModel.DataAnnotations;

namespace eGaraz.Models
{
    public class MedicalExamination : BaseEntity
    {
        public int? FiremenId { get; set; }

        public int? DriverId { get; set; }

        [Display(Name = "Nazwa Badania")]
        [Required(ErrorMessage = "Nazwa Badania jest wymagana")]
        public string Name { get; set; }

        [Display(Name = "Data Badania")]
        [Required(ErrorMessage = "Data Badania jest wymagana")]
        public DateTime IssueDate { get; set; }

        [Display(Name = "Data Ważności Badania")]
        public DateTime? ExpireDate { get; set; }

        [Display(Name = "Uwagi")]
        public string Comments { get; set; }

        public Firemen Firemen { get; set; }
        public Driver Driver { get; set; }
    }
}
