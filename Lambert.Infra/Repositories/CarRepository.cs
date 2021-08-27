using System.Collections.Generic;
using Lambert.Domain.Entities;
using Lambert.Domain.Interfaces.Repositories;

namespace Lambert.Infra.Repositories
{
    public class CarRepository : ICarRepository
    {
			IList<CarEntity> carList = new List<CarEntity>();

      public CarEntity Save(CarEntity entity)
      {
				carList.Add(entity);
				return entity;
      }
    }
}
