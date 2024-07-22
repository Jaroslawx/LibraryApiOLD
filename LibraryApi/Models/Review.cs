using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApi.Models;

public class Review
{
    [Key]
    public long Id { get; set; }
    [ForeignKey("Book")]
    public long BookId { get; set; }
    public Book Book { get; set; }
    public string Reviewer { get; set; }
    public string Comement { get; set; }
    public int Raiting { get; set; }
    
}