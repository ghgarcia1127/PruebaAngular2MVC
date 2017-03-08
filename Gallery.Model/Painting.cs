

namespace Gallery.Model
{
    using Domain;
    using System;

    public class Painting : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Total_in_Shelf { get; set; }

        public decimal Total_in_Vault { get; set; }

        public long Collection_Id { get; set; }

        public virtual Collection Collection { get; set; }
    }
}