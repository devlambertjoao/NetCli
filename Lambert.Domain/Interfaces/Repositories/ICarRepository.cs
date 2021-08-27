using Lambert.Domain.Entities;

namespace Lambert.Domain.Interfaces.Repositories
{
	public interface ICarRepository
	{
		CarEntity Save(CarEntity entity);
	}
}
