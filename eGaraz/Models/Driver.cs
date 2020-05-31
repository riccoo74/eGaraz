using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eGaraz.Models
{
    public class Driver : BaseEntity
    {
        public int? FiremenId { get; set; }

        [Display(Name = "Data Wydania Prawa Jazdy")]
        [Required(ErrorMessage = "Data Wydania Prawa Jazdy jest wymagana")]
        public DateTime DrivingLicenseIssueDate { get; set; }

        [Display(Name = "Data Ważności Prawa Jazdy")]
        public DateTime? DrivingLicenseExpDate { get; set; }

        [Display(Name = "Kategorie Prawa Jazdy")]
        [Required(ErrorMessage = "Kategorie Prawa Jazdy są wymagane")]
        public string DrivingLicenseCategories { get; set; }

        /// <summary>
        /// Date of expiry of the authorization to drive a emergency vehicle
        /// </summary>
        [Display(Name = "Data Ważności Pozwolenia Na Kierowanie Pojazdem Uprzywilejowanym")]
        public DateTime? PermissionExpDate { get; set; }

        [Display(Name = "Uwagi")]
        public string Comments { get; set; }

        public Firemen Firemen { get; set; }
        public ICollection<MedicalExamination> MedicalExaminations { get; set; }
    }
}
