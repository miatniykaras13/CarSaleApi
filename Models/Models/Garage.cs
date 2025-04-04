namespace Models.Models;

public class Garage
{
    public int GarageId { get; set; }
    public List<Car> Cars { get; set; }
    public User Owner { get; set; }

    public Garage()
    {
        Cars = new List<Car>();
        Owner = new User();
    }
}