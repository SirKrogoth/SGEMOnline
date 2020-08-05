using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMOnline.Business.Models.Validations
{
    public class ItemValidation : AbstractValidator<Item>
    {
        public ItemValidation()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode estar vazio.")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa estar entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(c => c.Preco)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}
