namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExtSysActiveResort
{
    public string? Resort { get; set; }
    public string? Code { get; set; }
    public string? DisplayYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? ConsumerName { get; set; }
    public string? SsoExternalValidationUrl { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtSysActiveResort>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Code })
                .HasName("EXT_SYS_ACT_RESORT_PK");

            entity.ToTable("EXT_SYS_ACTIVE_RESORT");

            entity.HasIndex(e => new { e.Code, e.Resort })
                .HasName("EXT_SYS_ACTIVE_RESORT_IDX1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumerName)
                .HasColumnName("CONSUMER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SsoExternalValidationUrl)
                .HasColumnName("SSO_EXTERNAL_VALIDATION_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
