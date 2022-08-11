using System.ComponentModel.DataAnnotations;

namespace GSS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}