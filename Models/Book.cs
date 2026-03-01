using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CetStudentBook.Models;

public class Book
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [Length(2,200)]
    [DisplayName("Full Name")]
    public string Name { get; set; }
    
    [Required]
    [Length(2,200)]
    [DisplayName("Author Name")]
    public string Author { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    [DisplayName("Publish Date")]
    public DateTime PublishDate { get; set; }
    
    [Required]
    [Range(1,10000)]
    [DisplayName("Page Count")]
    public int PageCount { get; set; }
    
    [Required]
    [DisplayName("Second Hand")]
    public bool IsSecondHand { get; set; }
}


