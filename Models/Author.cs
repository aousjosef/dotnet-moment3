namespace Moment_3.Models;

public class Author
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Nationality { get; set; }

    //Bättre med att initera book list redan här än att bara lämna den tom. 
    public List<Book>? Books { get; set; }

}

