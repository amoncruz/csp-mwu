using FluentValidation;

namespace MWU.Application.DTO.Integracao
{
    public class IntegracaoValidator : AbstractValidator<IntegracaoDTO>
    {
        public IntegracaoValidator()
        {
            RuleFor(i => i.Nome)
                .NotEmpty()
                .NotNull().WithMessage("Nome é obrigatorio!");
        }
    }
}
