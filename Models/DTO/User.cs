using Models.Models;

namespace Models.DTO;

public class UserDto
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Phone { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
}