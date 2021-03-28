using System.ComponentModel.DataAnnotations;

namespace WizeTech_Business_CRM.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
