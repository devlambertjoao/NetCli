using Lambert.Domain.Arguments.Services;
using Lambert.Domain.Interfaces.Services;
using Lambert.Domain.Interfaces.Repositories;
using Lambert.Domain.Entities;
using Lambert.Service.Mappers;

namespace Lambert.Service
{
    public class CarService : ICarService
    {
			private readonly ICarRepository _carRepository;
			private readonly CarMapper _carMapper;

			public CarService(ICarRepository carRepository)
			{
				_carRepository = carRepository;
				_carMapper = new CarMapper();
			}

      public CarSaveResponse Save(CarSaveRequest request)
			{
				CarEntity entity = _carMapper.ToEntity(new CarEntity(), request);
				_carRepository.Save(entity);

				return new CarSaveResponse();
      }
    }
}
