using System;
using System.Collections.Generic;

#nullable disable

namespace DerryLibraryAPI.Data
{
    public partial class Book
    {
        public Book()
        {
            BookConditions = new HashSet<BookCondition>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int LocationId { get; set; }
        public int CategoryId { get; set; }
        public int Status { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual Location Location { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<BookCondition> BookConditions { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
