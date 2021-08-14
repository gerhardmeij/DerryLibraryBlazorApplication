using System;
using System.Collections.Generic;

#nullable disable

namespace DerryLibraryAPI.Data
{
    public partial class BookCondition
    {
        public BookCondition()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public int BookId { get; set; }
        public int CondId { get; set; }
        public string Comment { get; set; }
        public int Status { get; set; }

        public virtual Book Book { get; set; }
        public virtual Condition Cond { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
