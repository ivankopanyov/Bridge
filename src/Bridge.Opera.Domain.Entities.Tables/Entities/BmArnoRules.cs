namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmArnoRules
{
    public string? AccountCode { get; set; }
    public string? Type { get; set; }
    public string? Resort { get; set; }
    public string? ChannelType { get; set; }
    public string? Channel { get; set; }
    public string? ArNumber { get; set; }
    public decimal? Weight { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmArnoRules>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BM_ARNO_RULES");

            entity.HasIndex(e => new { e.AccountCode, e.Resort })
                .HasName("BMAR_ACCOUNT");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Weight)
                .HasColumnName("WEIGHT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
