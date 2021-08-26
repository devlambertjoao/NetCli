using Lambert.Domain.Enums;

namespace Lambert.Domain.Arguments.Entities
{
		public class CarEntityArguments
		{
				public string Model { get; set; }
				public int Year { get; set; }
				public CarColorEnum Color { get; set; }
		}
}
