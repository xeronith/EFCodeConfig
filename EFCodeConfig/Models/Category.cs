using System.Collections.Generic;

namespace EFCodeConfig.Models
{
    class Category
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
