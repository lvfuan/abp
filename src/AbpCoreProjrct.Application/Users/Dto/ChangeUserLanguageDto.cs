using System.ComponentModel.DataAnnotations;

namespace AbpCoreProjrct.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}