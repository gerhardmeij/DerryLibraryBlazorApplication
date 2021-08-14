using System;
using System.Collections.Generic;

#nullable disable

namespace DerryLibraryAPI.Data
{
    public partial class Condition
    {
        public Condition()
        {
            BookConditions = new HashSet<BookCondition>();
        }

        public int Id { get; set; }
        public string Condition1 { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<BookCondition> BookConditions { get; set; }
    }
}
