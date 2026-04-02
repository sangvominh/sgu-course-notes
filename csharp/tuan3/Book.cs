using System;

// Book implement IComparable de giao tiep voi Sorting
public class Book : IComparable
{
    private string title;
    private string author;
    private int pages;
    private double price;

    public Book(string title, string author, int pages, double price)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
        this.price = price;
    }

    // Getter methods
    public string getTitle()
    {
        return title;
    }

    public string getAuthor()
    {
        return author;
    }

    public int getPages()
    {
        return pages;
    }

    public double getPrice()
    {
        return price;
    }

    // Setter methods
    public void setTitle(string value)
    {
        title = value;
    }

    public void setAuthor(string value)
    {
        author = value;
    }

    public void setPages(int value)
    {
        pages = value;
    }

    public void setPrice(double value)
    {
        price = value;
    }

    public override string ToString()
    {
        return "\"" + title + "\" - " + author + "\t" + pages + " pages\t$" + price;
    }

    public bool equals(Book other)
    {
        return title.Equals(other.getTitle()) && author.Equals(other.getAuthor());
    }

    // CompareTo - so sanh theo ten sach (title) tang dan
    // Neu ten sach giong nhau thi so sanh theo tac gia
    public int CompareTo(object obj)
    {
        Book other = (Book)obj;
        
        // Neu 2 Book bang nhau (dung equals), tra ve 0
        if (this.equals(other))
        {
            return 0;
        }
        
        // So sanh theo title truoc
        int result = title.CompareTo(other.getTitle());
        
        // Neu title giong nhau, so sanh theo author
        if (result == 0)
        {
            result = author.CompareTo(other.getAuthor());
        }
        
        return result;
    }
}