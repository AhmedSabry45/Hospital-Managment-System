using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Patients.Commands.Update
{
    public class UpdatePatientCommandValidator : AbstractValidator<UpdatePatientCommand>
    {
        public UpdatePatientCommandValidator()
        {
            string[] AllowedGenders = { "Male", "Female" };

            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Full Name is required.")
                .MaximumLength(250).WithMessage("Full Name cannot exceed 250 characters.");

            RuleFor(x => x.DateOfBirth)
                .NotEmpty().WithMessage("Date of Birth is required.");

            RuleFor(x => x.Gender)
                .NotEmpty().WithMessage("Gender is required.")
                .Must(gender => AllowedGenders.Contains(gender, StringComparer.OrdinalIgnoreCase))
                .WithMessage("Invalid gender value. Allowed values are: Male, Female.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone number is required.")
                .MaximumLength(20).WithMessage("Phone number cannot exceed 20 characters.");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Invalid email format.")
                .When(x => !string.IsNullOrEmpty(x.Email));

            RuleFor(x => x.Address)
                .MaximumLength(255).WithMessage("Address cannot exceed 255 characters.");

            RuleFor(x => x.EmergencyPhone)
                .MaximumLength(20).WithMessage("Emergency phone number cannot exceed 20 characters.")
                .When(x => !string.IsNullOrEmpty(x.EmergencyPhone));

            RuleFor(x => x.EmergencyContact)
                .MaximumLength(250).WithMessage("Emergency contact name cannot exceed 250 characters.");
        }
    }
}
