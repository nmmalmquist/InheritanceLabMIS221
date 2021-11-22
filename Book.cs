namespace mis221_lab_inheritance
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;

        public Book(string tempIsbn, string tempTitle, Author tempAuth)
        {
            this.isbn = tempIsbn;
            this.title = tempTitle;
            this.author = tempAuth;
        }

        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void SetAuthor(Author author)
        {
            this.author = author;
        }

        public string GetIsbn()
        {
            return this.isbn;
        }
        public string GetTitle()
        {
            return this.title;
        }
        public Author GetAuthor()
        {
            return this.author;
        }

        public override string ToString()
        {
            return $"isbn={this.isbn} title={this.title} {this.author.ToString()}";
        }

    }

}