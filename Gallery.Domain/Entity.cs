
namespace Gallery.Domain
{
    using System;

    [Serializable]
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }
}
