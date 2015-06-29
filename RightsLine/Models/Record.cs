using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RightsLine.Models
{
    [Description("Gender")]
    public enum GenderEnum
    {
        Male = 1,
        Female = 2
    }

    public class Record
    {
        [HiddenInput(DisplayValue = true)]
        [Key]
        public virtual int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number.")]
        public string Phone { get; set; }

        [DisplayName("Birth Date")]
        [Required(ErrorMessage = "The Birth Date field is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }

        [Required]
        [Range(1, 2, ErrorMessage = "The Gender field is required.")]
        [DisplayName("Gender")]
        public GenderEnum Gender { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}