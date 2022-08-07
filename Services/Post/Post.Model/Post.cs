﻿namespace Post.Model;
public record Post
{
  public int Id { get; set; }
  public string Title { get; set; }
  public int AuthorId { get; set; }
  public string Author { get; set; }
  public string Summary { get; set; }
  public string Content { get; set; }
  public DateTime PublishedDate { get; set; }
  public List<Category> Categories { get; set; }
}
