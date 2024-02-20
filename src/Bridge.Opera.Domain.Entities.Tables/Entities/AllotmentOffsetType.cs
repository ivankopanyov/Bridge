namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentOffsetType
{
    public AllotmentOffsetType()
    {
        AllotmentOffsetGrid = new HashSet<AllotmentOffsetGrid>();
    }

    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? OffsetType { get; set; }
    public string? IgnoreOffsetYn { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual ICollection<AllotmentOffsetGrid> AllotmentOffsetGrid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentOffsetType>(entity =>
        {
            entity.HasKey(e => new { e.AllotmentHeaderId, e.Resort, e.OffsetType })
                .HasName("ALLOTMENT_OFFSET_TYPE_PK");

            entity.ToTable("ALLOTMENT$OFFSET_TYPE");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("ALLOTMENT_OFFSET_TYPE_FK_I");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OffsetType)
                .HasColumnName("OFFSET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IgnoreOffsetYn)
                .HasColumnName("IGNORE_OFFSET_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.AllotmentOffsetType)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .HasConstraintName("ALLOTMENT_OFFSET_TYPE_FK");
        
			if (!types.Contains(typeof(AllotmentOffsetGrid)))
				entity.Ignore(e => e.AllotmentOffsetGrid);
		});
	}
}
