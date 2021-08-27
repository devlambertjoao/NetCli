using Lambert.Domain.Arguments.Services;

namespace Lambert.Domain.Interfaces.Services
{
	public interface ICarService
	{
		CarSaveResponse Save(CarSaveRequest request);
	}
}
