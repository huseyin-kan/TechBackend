using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CardValidator:AbstractValidator<Card>
    {
        public CardValidator()
        {
            RuleFor(c => c.CardNumber).CreditCard().WithMessage("Geçersiz kart numarası");
            RuleFor(c => c.CardScrty).Length(3, 3).WithMessage("Geçersiz güvenlik numarası");
            
        }
    }
}
