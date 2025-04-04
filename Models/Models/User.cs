namespace Models.Models;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
    public EGarage Garage { get; set; }
    public List<Car> Cars { get; set; }
    public List<Bookmark> Bookmarks { get; set; }
    public List<Ad> Ads { get; set; }
    
}