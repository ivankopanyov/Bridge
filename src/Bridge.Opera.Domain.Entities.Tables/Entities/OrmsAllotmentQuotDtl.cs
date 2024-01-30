namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAllotmentQuotDtl
{
    public OrmsAllotmentQuotDtl()
    {
        OrmsAllotmentQuotResp = new HashSet<OrmsAllotmentQuotResp>();
    }

    public decimal? RequestId { get; set; }
    public string? Resort { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? YieldCategory { get; set; }
    public decimal? RequestedRooms { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual OrmsAllotmentQuotHdr Request { get; set; }
    public virtual ICollection<OrmsAllotmentQuotResp> OrmsAllotmentQuotResp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAllotmentQuotDtl>(entity =>
        {
            entity.HasKey(e => new { e.RequestId, e.Resort, e.AllotmentDate, e.YieldCategory })
                .HasName("ORMS_ALLOTMENT_QUOT_DTL_PK");

            entity.ToTable("ORMS_ALLOTMENT_QUOT_DTL");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RequestedRooms)
                .HasColumnName("REQUESTED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsAllotmentQuotHdr)))
				entity.Ignore(e => e.Request);
			else
	            entity.HasOne(d => d.Request)
	                .WithMany(p => p.OrmsAllotmentQuotDtl)
	                .HasForeignKey(d => d.RequestId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_ALLOTMENT_QUOT_HDR_FK");
        
			if (!types.Contains(typeof(OrmsAllotmentQuotResp)))
				entity.Ignore(e => e.OrmsAllotmentQuotResp);
		});
	}
}
