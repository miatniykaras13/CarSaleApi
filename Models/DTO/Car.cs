using Models.Enum;
using Models.Models;

namespace Models.DTO;

public class CarDto
{
    public int CarId { get; set; }
    public User Owner { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Generation { get; set; }
    public string Color { get; set; }
    public string Year { get; set; }
    public Engine Engine { get; set; }
    public GearboxEnum Gearbox { get; set; }
    public CarcaseEnum Carcase { get; set; }
}