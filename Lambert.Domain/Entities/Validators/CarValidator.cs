using FluentValidation;

namespace Lambert.Domain.Entities.Validators
{
	public class CarValidator : AbstractValidator<CarEntity>
	{
		public CarValidator() {
			RuleFor(x => x.Color).NotEmpty().WithMessage("Color is required");
			RuleFor(x => x.Model).NotEmpty().WithMessage("Model is required");
			RuleFor(x => x.Year).NotEmpty().GreaterThanOrEqualTo(1885)
				.WithMessage("Year is required, and needs to be greater than or equal 1885");
		}
	}
}
