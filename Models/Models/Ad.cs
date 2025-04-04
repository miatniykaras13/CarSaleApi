namespace Models.Models;

public class Ad
{
    public int AdId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public User Publisher { get; set; }
    public int PriceInBy { get; set; }
    public int PriceInUsd { get; set; }
    public DateTime AdDate { get; set; }
    public bool IsDeleted { get; set; }
    
}