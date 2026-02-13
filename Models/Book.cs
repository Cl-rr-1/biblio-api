public class Book {
    // Properties
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }

    // public int YearPublished { get; set; }

    /*

    // Constructor
    public Book(int id, string title, string author) {
        Id = id;
        Title = title;
        Author = author;
    }

    // Override ToString for easy display
    public override string ToString() {
        return $"Book : \nID: -{Id}\n Title: -{Title}\n Author: -{Author}";
    }

    // Methods

    //** Method to update book details
    public void UpdateDetails(string title, string author) {
        Title = title;
        Author = author;
    }
    */
}