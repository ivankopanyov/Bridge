namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventCodesTemplate
{
    public string? EventCode { get; set; }
    public string? EventDesc { get; set; }
    public decimal? SellSequence { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ChainCode { get; set; }
    public string? BlackoutYn { get; set; }
    public string? ShowInOperaYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventCodesTemplate>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.EventCode })
                .HasName("EVENT_CODES_TEMPLATE_PK");

            entity.ToTable("EVENT_CODES_TEMPLATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventCode)
                .HasColumnName("EVENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlackoutYn)
                .IsRequired()
                .HasColumnName("BLACKOUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.EventDesc)
                .HasColumnName("EVENT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShowInOperaYn)
                .HasColumnName("SHOW_IN_OPERA_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
