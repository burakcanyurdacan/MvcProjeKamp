using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
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
            RuleFor(x => x.WriterAbout).Must(x => x.Contains("a") || x.Contains("A")).WithMessage("Hakkımda kısmında en az 1 defa 'A' harfi geçmelidir.");
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş geçemezsiniz");
        }
    }
}
