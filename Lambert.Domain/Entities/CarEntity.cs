using System;
using Lambert.Domain.Enums;
using Lambert.Domain.Arguments.Entities;
using Lambert.Domain.Entities.Validators;

namespace Lambert.Domain.Entities
{
  public class CarEntity : BaseEntity<Guid>
  {
    public string Model { get; private set; }
    public int Year { get; private set; }
    public CarColorEnum Color { get; private set; }

    public CarEntity(CarEntityArguments arg)
    {
			Model = arg.Model;
			Year = arg.Year;
            Color = Enum.Parse<CarColorEnum>(arg.Color.ToUpper());
		
			Validate(this, new CarValidator());
    }
    
		public CarEntity()
    {
    }
  }
}
