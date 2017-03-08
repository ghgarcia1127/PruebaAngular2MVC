namespace Gallery.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(Namespace = "http://schemas.gallery.com/dtos/2017/02")]
    public class Collection
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime Date { get; set; }
        
        public virtual ICollection<Painting> Paintings { get; set; }
    }
}
