namespace Models.Models;

public class EGarage
{
    public int EGarageId { get; set; }
    public List<Car> Cars { get; set; }
    public User Owner { get; set; }

    public EGarage()
    {
        Cars = new List<Car>();
        Owner = new User();
    }
}