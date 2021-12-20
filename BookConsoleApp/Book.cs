using System.Text;

namespace BookConsoleApp
{
    class Book
    {
        private string _title = "";
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                UpdateEditedAt();
            }
        }
        public DateTime CreatedAt { get; private set; }
        public DateTime EditedAt { get; private set; }

        public Book()
        {
            Title = "no title specified";
            CreatedAt = DateTime.Now;
            EditedAt = CreatedAt;
        }

        public Book(string title)
        {
            Title = title;
            CreatedAt = DateTime.Now;
            EditedAt = CreatedAt;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("Book { Title: ");
            sb.Append(Title);
            sb.Append(", Created At: ");
            sb.Append(CreatedAt.ToString());

            if (IsEdited())
            {
                sb.Append(", ");
                sb.Append("Edited At: ");
                sb.Append(EditedAt.ToString());
            }

            sb.Append(" }");

            return sb.ToString();
        }

        private bool IsEdited()
        {
            return (EditedAt > CreatedAt);
        }

        private void UpdateEditedAt()
        {
            EditedAt = DateTime.Now;
        }
    }
}
