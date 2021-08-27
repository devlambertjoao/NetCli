using Lambert.Domain.Arguments.Services;
using Lambert.Domain.Interfaces.Services;
using Lambert.Domain.Interfaces.Repositories;
using Lambert.Domain.Entities;
using Lambert.Service.Mappers;
using System;

namespace Lambert.Service
{
    public class CarService : ICarService
    {
			private readonly ICarRepository _carRepository;
			private readonly CarMapper _carMapper;

			public CarService(ICarRepository carRepository, CarMapper carMapper)
			{
				_carRepository = carRepository;
				_carMapper = carMapper;
			}

      public CarSaveResponse Save(CarSaveRequest request)
			{
				CarEntity entity = _carMapper.ToEntity(new CarEntity(), request);
				if(!entity.IsValid)
				{
					throw new Exception(entity.Errors.ToString());	
				}
				
				_carRepository.Save(entity);

				return new CarSaveResponse();
      }
    }
}
