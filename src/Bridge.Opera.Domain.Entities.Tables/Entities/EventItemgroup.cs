namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventItemgroup
{
    public EventItemgroup()
    {
        EventItem = new HashSet<EventItem>();
    }

    public decimal EventItemgId { get; set; }
    public decimal EventId { get; set; }
    public decimal ItmgId { get; set; }
    public string ItmgName { get; set; }
    public string HourlyYn { get; set; }
    public decimal? Price { get; set; }
    public string PriceCode { get; set; }
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal? Discount { get; set; }

    public virtual GemEvent Event { get; set; }
    public virtual ICollection<EventItem> EventItem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventItemgroup>(entity =>
        {
            entity.HasKey(e => e.EventItemgId)
                .HasName("EIG_PK");

            entity.ToTable("EVENT$ITEMGROUP");

            entity.HasIndex(e => e.EventId)
                .HasName("EIG_EVENT_ID_IDX");

            entity.HasIndex(e => new { e.Resort, e.BookId, e.EventId, e.EventItemgId })
                .HasName("EVP_UK")
                .IsUnique();

            entity.Property(e => e.EventItemgId)
                .HasColumnName("EVENT_ITEMG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HourlyYn)
                .HasColumnName("HOURLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ItmgId)
                .HasColumnName("ITMG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItmgName)
                .HasColumnName("ITMG_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.EventItemgroup)
	                .HasForeignKey(d => d.EventId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EIG_GE_FK");
        
			if (!types.Contains(typeof(EventItem)))
				entity.Ignore(e => e.EventItem);
		});
	}
}
