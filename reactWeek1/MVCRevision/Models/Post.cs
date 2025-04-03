using System;
using System.ComponentModel.DataAnnotations;

namespace MVCRevision.Models;

public class Post
{
    [Key]
    public int PostId { get; set; }
    public string Title { get; set; }
    public string? Content { get; set; }
    public DateTime? PublishedDate { get; set; }

}
