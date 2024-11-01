using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmbicaMasala.Services.AuthApi.Models
{
    public enum gender
    {
        male,
        female,
        trans
    }
    public class Rigister
    {
        [Key]
        // Name , Email , password , Age , Gender,  Adderess
        [Required]
        [EmailAddress]
        public string  Email  { get; set; }

        [StringLength(50)]
        [Display(Name = "User Age")]

        public string Name { get; set; }

        [Range (18,100)]
        [Required]
        public int Age { get; set; }


        [EnumDataType(typeof(gender))]
        [Required]
        public string Gender { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [Required]
        [PasswordPropertyText]// nont inheritabe object .
        [StringLength(20)]
        public string Password { get; set; }











    }
}
