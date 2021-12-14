namespace EFCodeFirstApp.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Code { get; set; }

        public void CloneIt(Book book)
        {
            Name = book.Name;
            Author = book.Author;
            Code = book.Code;
        }
    }


}
