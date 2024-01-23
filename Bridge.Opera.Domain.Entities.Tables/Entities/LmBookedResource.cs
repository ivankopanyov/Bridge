namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmBookedResource
{
    public decimal BookedResId { get; set; }
    public string Resort { get; set; }
    public decimal BookedActId { get; set; }
    public decimal? BookedElId { get; set; }
    public string ResType { get; set; }
    public string ResId { get; set; }
    public decimal Price { get; set; }
    public decimal Qty { get; set; }
    public decimal Priority010 { get; set; }
    public string AddonYn { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual LmBookedElements LmBookedElements { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookedResource>(entity =>
        {
            entity.HasKey(e => new { e.BookedResId, e.Resort })
                .HasName("LM_BOOK_RES_PK");

            entity.ToTable("LM_BOOKED_RESOURCE");

            entity.HasIndex(e => new { e.TrxNo, e.Resort })
                .HasName("LM_BOOK_RES_IND");

            entity.HasIndex(e => new { e.BookedActId, e.Resort, e.BookedResId })
                .HasName("LM_BOOKED_RESOURCE_IND3");

            entity.HasIndex(e => new { e.BookedElId, e.Resort, e.BookedResId })
                .HasName("LM_BOOK_RES_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.ResId, e.ResType, e.Resort, e.BookedElId })
                .HasName("LM_BOOKED_RES_IND2");

            entity.Property(e => e.BookedResId)
                .HasColumnName("BOOKED_RES_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddonYn)
                .HasColumnName("ADDON_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedElId)
                .HasColumnName("BOOKED_EL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority010)
                .HasColumnName("PRIORITY0_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Qty)
                .HasColumnName("QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResId)
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResType)
                .IsRequired()
                .HasColumnName("RES_TYPE")
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
			else
	            entity.HasOne(d => d.LmBookedElements)
	                .WithMany(p => p.LmBookedResource)
	                .HasForeignKey(d => new { d.BookedElId, d.Resort })
	                .HasConstraintName("LM_BOOK_RES_FK");
        });
	}
}
