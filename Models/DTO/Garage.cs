using Models.Models;
namespace Models.DTO;


public class GarageDto
{
    public int GarageId { get; set; }
    public List<Car> Cars { get; set; }
    public User Owner { get; set; }

    public GarageDto()
    {
        Cars = new List<Car>();
        Owner = new User();
    }
}