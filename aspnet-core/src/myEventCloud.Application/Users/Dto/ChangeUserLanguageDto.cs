using System.ComponentModel.DataAnnotations;

namespace myEventCloud.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}