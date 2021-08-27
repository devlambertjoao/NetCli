using Lambert.Domain.Enums;

namespace Lambert.Domain.Arguments.Services
{
	public class CarSaveRequest
	{
		public string Model { get; set; }
    public int Year { get; set; }
    public CarColorEnum Color { get; set; }
	}
}
