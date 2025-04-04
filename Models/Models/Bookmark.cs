namespace Models.Models;

public class Bookmark
{
    public int BookmarkId { get; set; }
    public User User { get; set; }
    public Ad Ad { get; set; }
    
}