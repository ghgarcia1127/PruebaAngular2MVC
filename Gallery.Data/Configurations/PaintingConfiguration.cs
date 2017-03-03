
namespace Gallery.Data.Configurations
{
    using Model;
    using System.Data.Entity.ModelConfiguration;

    public class PaintingConfiguration : EntityTypeConfiguration<Painting>
    {
        public PaintingConfiguration()
        {
            ToTable("Paintings");

            HasKey(P => P.Id);
            Property(P => P.Name);
            Property(P => P.Description);
            Property(P => P.Price);
            Property(P => P.Total_in_Shelf);
            Property(P => P.Total_in_Vault);

            HasRequired(P => P.Collection).WithMany(C => C.Paintings).HasForeignKey(C => C.Collection_Id);
        }
    }
}
