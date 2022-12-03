using EntityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.FluentValidator
{
    public class İmageValidator: AbstractValidator<İmage>
    {
        public İmageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel Başlığı Boş Geçilemez");
            RuleFor(x => x.Decription).NotEmpty().WithMessage("Görsel Açıklaması Boş Geçilemez!");
            RuleFor(x => x.İmageUrl).NotEmpty().WithMessage("Görsel Yolunu Boş Geçemezsiniz.");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Görsel Başlığı 8 karakterden az olamaz!");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Görsel Başlığı 20 Karakterden Fazla Olamaz!");
            RuleFor(x => x.Decription).MinimumLength(8).WithMessage("Görsel Açıklaması 8 Karakterden Daha Az Olamaz !");
            RuleFor(x => x.Decription).MaximumLength(50).WithMessage("lütfen açıklama kısmına En Fazla 50 Karakter Girebilirsiniz");
        }
    }
}
