using System.ComponentModel.DataAnnotations;

namespace ExamControl.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}