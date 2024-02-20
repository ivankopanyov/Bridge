namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationItems
{
    public decimal? ReservationItemId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ProductCode { get; set; }
    public string? RateCode { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? ItemId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? ReservationProductId { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationItems>(entity =>
        {
            entity.HasKey(e => e.ReservationItemId)
                .HasName("RESV_ITM_PK");

            entity.ToTable("RESERVATION_ITEMS");

            entity.HasIndex(e => new { e.ItemId, e.Resort })
                .HasName("RESV_ITM_RESORT_ITEMID_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("RESV_ITM_IND1");

            entity.Property(e => e.ReservationItemId)
                .HasColumnName("RESERVATION_ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProductCode)
                .HasColumnName("PRODUCT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationProductId)
                .HasColumnName("RESERVATION_PRODUCT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationItems)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("RESV_ITM_RESV_NAME_FK");
        });
	}
}
