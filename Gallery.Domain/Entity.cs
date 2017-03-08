
namespace Gallery.Domain
{
    using System;

    [Serializable]
    public abstract class Entity
    {
        public long Id { get; set; }
    }
}
