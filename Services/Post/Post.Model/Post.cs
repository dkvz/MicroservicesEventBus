namespace Post.Model;
public class Post
{
  public int? Id { get; set; }
  public string Title { get; set; }
  public int AuthorId { get; set; }
  public string Author { get; set; }
  public string Summary { get; set; }
  public string Content { get; set; }
  public DateTime PublishedDate { get; set; }
  public List<Category> Categories { get; set; }

  public Post(int id, string title, int authorId, string author, string summary,
    string content, DateTime publishedDate, List<Category> categories)
  {
    Id = id;
    Title = title;
    AuthorId = authorId;
    Author = author;
    Summary = summary;
    Content = content;
    PublishedDate = publishedDate;
    Categories = categories;
  }
}
