using System;
using Lambert.Domain.Enums;
using Lambert.Domain.Arguments.Entities;

namespace Lambert.Domain.Entities
{
		public class CarEntity : BaseEntity<Guid>
		{
				public string Model { get; private set; }
				public int Year { get; private set; }
				public CarColorEnum Color { get; private set; }

				public CarEntity(CarEntityArguments arg)
				{

				}

				public CarEntity()
				{
				}
		}
}
