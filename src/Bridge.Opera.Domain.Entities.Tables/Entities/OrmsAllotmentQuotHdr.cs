namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAllotmentQuotHdr
{
    public OrmsAllotmentQuotHdr()
    {
        OrmsAllotmentQuotDtl = new HashSet<OrmsAllotmentQuotDtl>();
    }

    public decimal? RequestId { get; set; }
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? BlockStatus { get; set; }
    public DateTime? RequestDate { get; set; }
    public string? RequestType { get; set; }
    public DateTime? BlockBeginDate { get; set; }
    public DateTime? BlockEndDate { get; set; }
    public decimal? RequestedAmount { get; set; }
    public string? ResponseStatus { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? TotalRooms { get; set; }
    public string? BlockCode { get; set; }

    public virtual ICollection<OrmsAllotmentQuotDtl> OrmsAllotmentQuotDtl { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAllotmentQuotHdr>(entity =>
        {
            entity.HasKey(e => e.RequestId)
                .HasName("ORMS_ALLOTMENT_QUOT_HDR_PK");

            entity.ToTable("ORMS_ALLOTMENT_QUOT_HDR");

            entity.HasIndex(e => new { e.BlockCode, e.Resort, e.RequestId })
                .HasName("ORMS_ALLOT_QUOT_HDR_IND");

            entity.HasIndex(e => new { e.Resort, e.AllotmentHeaderId, e.BlockStatus, e.BlockBeginDate, e.BlockEndDate, e.RequestType, e.RequestDate })
                .HasName("ORMS_ALLOTMENT_QUOT_HDR_UK")
                .IsUnique();

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockBeginDate)
                .HasColumnName("BLOCK_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlockEndDate)
                .HasColumnName("BLOCK_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockStatus)
                .IsRequired()
                .HasColumnName("BLOCK_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestType)
                .IsRequired()
                .HasColumnName("REQUEST_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'S'");

            entity.Property(e => e.RequestedAmount)
                .HasColumnName("REQUESTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResponseStatus)
                .HasColumnName("RESPONSE_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(OrmsAllotmentQuotDtl)))
				entity.Ignore(e => e.OrmsAllotmentQuotDtl);
		});
	}
}
