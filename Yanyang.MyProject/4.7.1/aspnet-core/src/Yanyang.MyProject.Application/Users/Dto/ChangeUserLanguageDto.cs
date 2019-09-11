using System.ComponentModel.DataAnnotations;

namespace Yanyang.MyProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}