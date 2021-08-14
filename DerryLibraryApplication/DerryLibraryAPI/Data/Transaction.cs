using System;
using System.Collections.Generic;

#nullable disable

namespace DerryLibraryAPI.Data
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int CondId { get; set; }
        public DateTime IssueTmStamp { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; }

        public virtual Book Book { get; set; }
        public virtual BookCondition Cond { get; set; }
        public virtual User User { get; set; }
    }
}
