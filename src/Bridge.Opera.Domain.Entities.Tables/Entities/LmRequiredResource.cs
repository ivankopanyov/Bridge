namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmRequiredResource
{
    public decimal? ReqSeq { get; set; }
    public string? Resort { get; set; }
    public string? ActElCode { get; set; }
    public string? ActCode { get; set; }
    public string? ResType { get; set; }
    public decimal? Quantity { get; set; }
    public string? ForceAssignYn { get; set; }
    public decimal? Priority010 { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmRequiredResource>(entity =>
        {
            entity.HasKey(e => new { e.ReqSeq, e.Resort })
                .HasName("LM_ACT_REQ_PK");

            entity.ToTable("LM_REQUIRED_RESOURCE");

            entity.HasIndex(e => new { e.ResType, e.Resort })
                .HasName("LM_REQ_RES_IND3");

            entity.HasIndex(e => new { e.ActCode, e.Resort, e.ResType })
                .HasName("LM_REQ_RES_IND2");

            entity.HasIndex(e => new { e.ActElCode, e.Resort, e.ResType })
                .HasName("LM_REQ_RES_IND");

            entity.Property(e => e.ReqSeq)
                .HasColumnName("REQ_SEQ")
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

            entity.Property(e => e.ActElCode)
                .HasColumnName("ACT_EL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ForceAssignYn)
                .IsRequired()
                .HasColumnName("FORCE_ASSIGN_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

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

            entity.Property(e => e.Priority010)
                .HasColumnName("PRIORITY0_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResType)
                .IsRequired()
                .HasColumnName("RES_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
