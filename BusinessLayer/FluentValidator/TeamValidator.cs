using EntityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.FluentValidator
{
    public class TeamValidator:AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(F => F.PersonName).NotEmpty().WithMessage("Personel Adı Boş Geçilemez");
            RuleFor(f => f.PersonName).MinimumLength(5).WithMessage("Personel Adı Ve Soyadı en Az 5 Karakter Olmalıdır!");
            RuleFor(f => f.PersonName).MaximumLength(50).WithMessage("Personel Adı Soyadı Alanı 50 Karakterden Fazla Olamaz!");
            RuleFor(f => f.Title).NotEmpty().WithMessage("Görev Alanı Boş Geçilemez!");
            RuleFor(f => f.Title).MinimumLength(5).WithMessage("Görev Alanı En AZ 5 Karakterli Olmalıdır");
            RuleFor(F => F.Title).MaximumLength(10).WithMessage("Görev alanının uzunluğu 10 karakteri geçemez");
        }
    }
}
