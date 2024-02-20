namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiAccessCodes
{
    public string? AccessLevel { get; set; }
    public string? AccessCode { get; set; }
    public string? AccessDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAccessCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ACCESS_CODES");

            entity.Property(e => e.AccessCode)
                .HasColumnName("ACCESS_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AccessDesc)
                .HasColumnName("ACCESS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AccessLevel)
                .HasColumnName("ACCESS_LEVEL")
                .HasMaxLength(11)
                .IsUnicode(false);
        });
	}
}
