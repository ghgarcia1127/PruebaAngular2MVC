

namespace Gallery.Model
{
    using Domain;
    using System;
    using System.Collections.Generic;

    public class Collection : Entity
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<Painting> Paintings { get; set; }
        
    }
}
