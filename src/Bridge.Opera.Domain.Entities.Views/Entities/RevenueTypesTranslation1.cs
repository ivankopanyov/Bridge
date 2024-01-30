namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RevenueTypesTranslation1
{
    public string? RevType { get; set; }
    public string? Language { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RevenueTypesTranslation1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REVENUE_TYPES_TRANSLATION");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .IsRequired()
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
