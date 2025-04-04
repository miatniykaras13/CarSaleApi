using Models.Models;

namespace Models.DTO;


public class BookmarkDto
{
    public int BookmarkId { get; set; }
    public User User { get; set; }
    public Ad Ad { get; set; }
}