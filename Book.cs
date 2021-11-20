namespace Composition_Lab
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;

        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            this.isbn = tempIsbn;
            this.title = tempTitle;
            this.author = tempAuthor;
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public void SetIsbn(string tempIsbn)
        {
            this.isbn = tempIsbn;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string tempTitle)
        {
            this.title = tempTitle;
        }

        public Author GetAuthor()
        {
            return author;
        }

        public void SetAuthor(Author tempAuthor)
        {
            this.author = tempAuthor;
        }

        public override string ToString()
        {
            return "ISBN = " + isbn + ", Title = " + title + ", " + author.ToString();
        }
    }
}