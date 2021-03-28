using System.ComponentModel.DataAnnotations;

namespace WizeTech_Business_CRM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}