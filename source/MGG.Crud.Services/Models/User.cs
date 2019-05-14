using System;
using System.Linq;
using FluentValidation;
using MGG.Crud.Infra.CrossCutting.Global;

namespace MGG.Crud.Services.Models
{
    public class User : Entity<User>
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Phone { get; set; }

        
        public override bool IsValid()
        {
            RuleFor(x => x.Name)
                .Length(2, 120).WithMessage(Label.LenghtMessage);

            RuleFor(x => x.LastName)
                .Length(2, 100).WithMessage(Label.LenghtMessage);

            RuleFor(x => x.Phone)
                .Length(20).WithMessage(Label.LenghtMessage);

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}