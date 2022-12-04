using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty().WithMessage("Kullanıcı ismi boş olamaz");
            RuleFor(u => u.UserPassword).NotEmpty().Length(6, 15).WithMessage("Şifreniz 6 ile 15 karakter arasında olmalıdır");
            RuleFor(u => u.UserSurName).NotEmpty().WithMessage("Kullanıcı soyadı boş olamaz");
            RuleFor(u => u.UserPhone).Length(10, 10).WithMessage("Numara geçersiz");
            RuleFor(u => u.UserAddress).NotEmpty().WithMessage("Adres bölümü eksik olamaz");
            RuleFor(u => u.UserEmail).EmailAddress().WithMessage("Email adresi geçersiz");
            RuleFor(u => u.UserDateOfBirth).NotEmpty().WithMessage("Doğum tarihi boş olamaz");
        }
    }
}
