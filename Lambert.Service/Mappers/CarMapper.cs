using Lambert.Domain.Arguments.Entities;
using Lambert.Domain.Arguments.Services;
using Lambert.Domain.Entities;

namespace Lambert.Service.Mappers
{
	public class CarMapper
	{
		public CarEntity ToEntity(CarEntity entity, CarSaveRequest request)
		{
			var entityArgs = new CarEntityArguments();
			entityArgs.Year = request.Year;
			entityArgs.Color = request.Color;
			entityArgs.Model = request.Model;

			return new CarEntity(entityArgs);
		}
	}
}
