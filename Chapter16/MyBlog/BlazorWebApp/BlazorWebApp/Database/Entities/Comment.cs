//using Markdig.Syntax.Inlines;
//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebApp.Database.Entities;

public class Comment
{
    public int Id { get; set; }

    public int BlogPostId { get; set; }
    public BlogPost BlogPost { get; set; } = null!;

    public DateTime Date { get; set; }
    public string Text { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
