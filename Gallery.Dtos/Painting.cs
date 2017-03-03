namespace Gallery.Dtos
{
    using System;
    using System.Runtime.Serialization;

    [DataContract(Namespace = "http://schemas.gallery.com/dtos/2017/02")]
    public class Painting
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public decimal Total_in_Shelf { get; set; }

        [DataMember]
        public decimal Total_in_Vault { get; set; }

        [DataMember]
        public Guid Collection_Id { get; set; }
        
        public string CollectionName { get; set; }
    }
}
