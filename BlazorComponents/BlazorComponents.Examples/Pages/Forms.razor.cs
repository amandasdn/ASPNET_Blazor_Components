using Microsoft.AspNetCore.Components;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorComponents.Examples.Pages
{
    public class FormsModel : LayoutComponentBase
    {
        public class PersonExample
        {
            [Display(Name = "Nome")]
            public string Name { get; set; }

            [Display(Name = "Sobrenome")]
            public string Surname { get; set; }

            [Display(Name = "Idade")]
            public int Age { get; set; }

            [Display(Name = "Data de Nascimento")]
            public DateTime Birthday { get; set; }

            [Display(Name = "Gênero")]
            public string Gender { get; set; }

            [Display(Name = "Ativo")]
            public bool IsActive { get; set; }

            [Display(Name = "Programadora")]
            public bool IsProgrammer { get; set; }
        }

        public PersonExample PersonObj = new PersonExample
        {
            Name = "Amanda",
            Surname = "Nascimento",
            Age = (DateTime.Now.Year - 1999),
            Birthday = new DateTime(1999, 06, 20),
            Gender = "f",
            IsActive = false,
            IsProgrammer = true
        };
    }
}
