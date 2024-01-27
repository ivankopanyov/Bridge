namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsConvCurrencies
{
    public string GdsHost { get; set; }
    public string CurrencyCode { get; set; }
    public string GdsCurrencyCode { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? LanyonDecimalPosition { get; set; }
    public decimal GdsDecimalPosition { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsConvCurrencies>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_CONV_CURRENCIES");

            entity.HasIndex(e => new { e.GdsHost, e.CurrencyCode })
                .HasName("GDS_CONV_CURRENCIES_IND1")
                .IsUnique();

            entity.HasIndex(e => new { e.GdsHost, e.GdsCurrencyCode })
                .HasName("GDS_CONV_CURRENCIES_IND2")
                .IsUnique();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsCurrencyCode)
                .IsRequired()
                .HasColumnName("GDS_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsDecimalPosition)
                .HasColumnName("GDS_DECIMAL_POSITION")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("2 ");

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanyonDecimalPosition)
                .HasColumnName("LANYON_DECIMAL_POSITION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
