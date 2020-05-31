using System;
using System.ComponentModel.DataAnnotations;


namespace eGaraz.Models
{
    public class Training : BaseEntity
    {
        [Required]
        public int FiremenId { get; set; }

        [Display(Name = "Nazwa Szkolenia")]
        [Required(ErrorMessage = "Nazwa Szkolenia jest wymagana")]
        public string Name { get; set; }

        [Display(Name = "Data Szkolenia")]
        [Required(ErrorMessage = "Data Szkolenia jest wymagana")]
        public DateTime Date { get; set; }

        [Display(Name = "Data Ważności Szkolenia")]
        public DateTime? ExpireDate { get; set; }

        [Display(Name = "Uwagi")]
        public string Comments { get; set; }

        public Firemen Firemen { get; set; }
    }
}
