namespace Bridge.Opera.Domain.Entities.Tables;

public partial class YieldMarketType
{
    public string? Resort { get; set; }
    public string? YmCode { get; set; }
    public string? YmDesc { get; set; }
    public string? YmAlternative { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? DefaultYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<YieldMarketType>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.YmCode })
                .HasName("YMT_PK");

            entity.ToTable("YIELD_MARKET_TYPE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YmCode)
                .HasColumnName("YM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YmAlternative)
                .HasColumnName("YM_ALTERNATIVE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YmDesc)
                .HasColumnName("YM_DESC")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
