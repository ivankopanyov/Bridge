namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConPhone
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? DefaultIndicator { get; set; }
    public string? PhoneType { get; set; }
    public string? PhoneNumber { get; set; }
    public string? PrimaryYn { get; set; }
    public string? PhoneRole { get; set; }
    public string? ShareEmailYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConPhone>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_PHONE");

            entity.Property(e => e.DefaultIndicator)
                .HasColumnName("DEFAULT_INDICATOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PhoneRole)
                .HasColumnName("PHONE_ROLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ShareEmailYn)
                .HasColumnName("SHARE_EMAIL_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
