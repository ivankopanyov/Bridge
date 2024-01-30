namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAllotmentQuotResp
{
    public decimal? RequestId { get; set; }
    public string? Resort { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? YieldCategory { get; set; }
    public string? RespType { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? RespAmount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual OrmsAllotmentQuotDtl OrmsAllotmentQuotDtl { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAllotmentQuotResp>(entity =>
        {
            entity.HasKey(e => new { e.RequestId, e.Resort, e.AllotmentDate, e.YieldCategory, e.RespType, e.RespAmount })
                .HasName("ORMS_ALLOTMENT_QUOT_RESP_PK");

            entity.ToTable("ORMS_ALLOTMENT_QUOT_RESP");

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

            entity.Property(e => e.RespType)
                .HasColumnName("RESP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RespAmount)
                .HasColumnName("RESP_AMOUNT")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

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
			else
	            entity.HasOne(d => d.OrmsAllotmentQuotDtl)
	                .WithMany(p => p.OrmsAllotmentQuotResp)
	                .HasForeignKey(d => new { d.RequestId, d.Resort, d.AllotmentDate, d.YieldCategory })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_ALLOTMENT_QUOT_RESP_FK");
        });
	}
}
