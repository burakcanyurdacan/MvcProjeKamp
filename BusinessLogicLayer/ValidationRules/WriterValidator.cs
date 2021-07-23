using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı en az 2 karakter olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz.");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar soyadı en az 2 karakter olmalıdır.");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Yazar soyadı en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını boş geçemezsiniz.");
            RuleFor(x => x.WriterAbout).Must(IsContain).WithMessage("Hakkımda kısmında en az 1 defa 'A' harfi geçmelidir.");
            RuleFor(x => x.WriterAbout).MaximumLength(100).WithMessage("Hakkımda kısmı en fazla 100 karakter olmalıdır.");
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail alanını boş geçemezsiniz.");
            RuleFor(x => x.WriterMail).MaximumLength(100).WithMessage("Mail en fazla 100 karakter olmalıdır.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(x => x.WriterPassword).Length(3,15).WithMessage("Şifre 3-15 karakter arasında olmalıdır.");
        }

        private bool IsContain(string word)
        {
            if (string.IsNullOrEmpty(word)) word = "";
            bool res = word.Contains("a");
            return res;
        }
    }
}
