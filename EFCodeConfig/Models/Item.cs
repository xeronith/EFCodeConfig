using System.Collections.Generic;

namespace EFCodeConfig.Models
{
    class Item
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual Category Category { get; set; }
    }
}
