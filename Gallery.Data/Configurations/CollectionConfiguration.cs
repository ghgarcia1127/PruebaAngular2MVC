

namespace Gallery.Data.Configurations
{
    using Model;
    using System.Data.Entity.ModelConfiguration;

    public class CollectionConfiguration : EntityTypeConfiguration<Collection>
    {
        public CollectionConfiguration()
        {
            ToTable("Collections");

            HasKey(C => C.Id);
            Property(C => C.Name);
            Property(C => C.Date);
            HasMany(C => C.Paintings).WithRequired().HasForeignKey(A => A.Collection_Id).WillCascadeOnDelete(true);
        }
    }
}
