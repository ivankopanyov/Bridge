namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiSaDescVw
{
    public string Code { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiSaDescVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SA_DESC_VW");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
