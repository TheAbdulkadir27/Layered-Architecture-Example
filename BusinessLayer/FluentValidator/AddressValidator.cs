using EntityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.FluentValidator
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama 1 Alanı Boş Geçilemez");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama 2 Alanı Boş Geçilemez");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama 3 Alanı Boş Geçilemez");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama 4 Alanı Boş Geçilemez");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Lütfen Harita Konumunu Yazın");
            RuleFor(x => x.Description1).MaximumLength(30).WithMessage("Açıklama1 Alanı Maximum 30 Karakter Olmalıdır1");
            RuleFor(x => x.Description2).MaximumLength(30).WithMessage("Açıklama2 Alanı Maximum 30 Karakter Olmalıdır1");
            RuleFor(x => x.Description3).MaximumLength(30).WithMessage("Açıklama3 Alanı Maximum 30 Karakter Olmalıdır1");
            RuleFor(x => x.Description4).MaximumLength(30).WithMessage("Açıklama4 Alanı Maximum 30 Karakter Olmalıdır1");
            RuleFor(x => x.Description1).MinimumLength(8).WithMessage("Açıklama 1 Alanı Minimum 8 Karakter Olmalıdır1");
            RuleFor(x => x.Description2).MinimumLength(8).WithMessage("Açıklama 2 Alanı Minimum 8 Karakter Olmalıdır1");
            RuleFor(x => x.Description3).MinimumLength(8).WithMessage("Açıklama 3 Alanı Minimum 8 Karakter Olmalıdır1");
            RuleFor(x => x.Description4).MinimumLength(8).WithMessage("Açıklama 4 Alanı Minimum 8 Karakter Olmalıdır1");
        }
    }
}
