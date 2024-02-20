namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RestrictionCodes
{
    public string? Code { get; set; }
    public string? Description { get; set; }
    public decimal? Seq { get; set; }
    public string? RestrictionTypes { get; set; }
    public string? RestrictionTypesDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RestrictionCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESTRICTION_CODES");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(28)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionTypes)
                .HasColumnName("RESTRICTION_TYPES")
                .HasMaxLength(17)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionTypesDesc)
                .HasColumnName("RESTRICTION_TYPES_DESC")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER");
        });
	}
}
