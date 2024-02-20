namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmBookedActivity
{
    public LmBookedActivity()
    {
        LmBookedElements = new HashSet<LmBookedElements>();
    }

    public decimal? BookedActId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string? ActCode { get; set; }
    public string? Status { get; set; }
    public decimal? Price { get; set; }
    public decimal? TrxNo { get; set; }
    public string? PriceCode { get; set; }
    public DateTime? CancelDate { get; set; }
    public decimal? NoOfPeople { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<LmBookedElements> LmBookedElements { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookedActivity>(entity =>
        {
            entity.HasKey(e => new { e.BookedActId, e.Resort })
                .HasName("LM_BOOKED_PKG_PK");

            entity.ToTable("LM_BOOKED_ACTIVITY");

            entity.HasIndex(e => new { e.ActCode, e.Resort })
                .HasName("LM_BOOKED_ACTIVITY_IND3");

            entity.HasIndex(e => new { e.NameId, e.Resort })
                .HasName("LM_BOOKED_ACTIVITY_IND4");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("LM_BOOKED_ACTIVITY_IND");

            entity.HasIndex(e => new { e.TrxNo, e.Resort })
                .HasName("LM_BOOKED_ACTIVITY_IND2");

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasColumnName("ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancelDate)
                .HasColumnName("CANCEL_DATE")
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

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfPeople)
                .HasColumnName("NO_OF_PEOPLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(LmBookedElements)))
				entity.Ignore(e => e.LmBookedElements);
		});
	}
}
