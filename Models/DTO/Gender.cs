using Models.Models;

namespace Models.DTO;

public class GenderDto
{
    public int GenderId { get; set; }
    public string Name { get; set; }

    List<User> Users { get; set; }
    public GenderDto()
    {
        Users = new List<User>();
    }
}