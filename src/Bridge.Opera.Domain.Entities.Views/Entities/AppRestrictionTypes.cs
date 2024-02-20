namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AppRestrictionTypes
{
    public string? Code { get; set; }
    public string? Description { get; set; }
    public decimal? Seq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppRestrictionTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("APP_RESTRICTION_TYPES");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(17)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(28)
                .IsUnicode(false);

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER");
        });
	}
}
