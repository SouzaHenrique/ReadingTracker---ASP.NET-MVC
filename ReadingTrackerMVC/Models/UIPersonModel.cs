using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadingTrackerMVC.Models
{
    public class UIPersonModel
    {
        /// <summary>
        /// The unique identifier for a person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The person's first name
        /// </summary>
        [Display(Name = "Primeiro Nome")]
        [Required(ErrorMessage = "Digite seu nome.")]        
        public string FirstName { get; set; }

        /// <summary>
        /// Person's last name
        /// </summary>
        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "Digite seu sobrenome.")]
        public string LastName { get; set; }

        /// <summary>
        /// Person's birthday date
        /// </summary>
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Digite a data de seu nascimento.")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDayDate { get; set; }

        /// <summary>
        /// Person's email address
        /// </summary>
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Digite seu e-mail.")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Person's confirmation address field
        /// </summary>
        [Display(Name = "Confirme seu e-mail")]
        [Compare("EmailAddress",ErrorMessage = "Os e-mails devem coincidir.")]
        public string ConfirmEmailAddress { get; set; }

        /// <summary>
        /// Person's Password
        /// </summary>
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Digite sua senha")]
        [DataType(DataType.Password)]
        [StringLength(1000, MinimumLength = 8, ErrorMessage = "Mínimo de 8 caracteres.")]        
        public string Password { get; set; }

        /// <summary>
        /// Person's confirmation password field
        /// </summary>
        [Display(Name = "Confirmar sua senha")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas devem coincidir.")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// Determines if a person is active in the platform, always true when created.
        /// </summary>
        public bool isActive { get; set; } = true;
    }
}