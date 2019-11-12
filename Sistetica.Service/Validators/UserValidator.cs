using FluentValidation;
using Sistetica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistetica.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Empty object.");
                    });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("É necessário informar o CPF.")
                .NotNull().WithMessage("É necessário informar o CPF.");

            RuleFor(c => c.DataAniversario)
                .NotEmpty().WithMessage("É necessário informar a data de aniversário.")
                .NotNull().WithMessage("É necessário informar a data de aniversário.");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("É necessário informar o nome.")
                .NotNull().WithMessage("É necessário informar o nome.");
        }
    }
}
