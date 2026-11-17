//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebApp.Database.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<BlogPost> BlogPosts { get; set; } = [];
}
