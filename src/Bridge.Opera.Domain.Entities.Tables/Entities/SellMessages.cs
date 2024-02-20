namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SellMessages
{
    public decimal? SellId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? SellMessage { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Resort { get; set; }
    public string? RoomCategory { get; set; }
    public string? RateCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? ChainCode { get; set; }
    public string? LanguageCode { get; set; }
    public string? StickyYn { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual RateHeader R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SellMessages>(entity =>
        {
            entity.HasKey(e => e.SellId)
                .HasName("SELL_MESSAGES_PK");

            entity.ToTable("SELL_MESSAGES");

            entity.HasIndex(e => new { e.Resort, e.AllotmentHeaderId })
                .HasName("SELL_MESSAGES_N2");

            entity.HasIndex(e => new { e.Resort, e.RateCode })
                .HasName("SELL_MESSAGE_FK_IDX");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory, e.RateCode })
                .HasName("SELL_MESSAGE_N1");

            entity.Property(e => e.SellId)
                .HasColumnName("SELL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'E'");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellMessage)
                .IsRequired()
                .HasColumnName("SELL_MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StickyYn)
                .HasColumnName("STICKY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.SellMessages)
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .HasConstraintName("RATE_SELL_MESSAGES");
        });
	}
}
