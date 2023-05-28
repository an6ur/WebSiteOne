using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace WebSiteOne.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Вам нужно ввести имя")]
        [Display(Name = "Введите имя")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string Surname { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Вам нужно ввести почту")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        [StringLength(30, ErrorMessage = "Напишите сообщение меньше 30 символов!")]
        public string Message { get; set; }
    }
}
