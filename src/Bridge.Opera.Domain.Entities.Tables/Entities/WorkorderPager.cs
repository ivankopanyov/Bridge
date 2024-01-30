namespace Bridge.Opera.Domain.Entities.Tables;

public partial class WorkorderPager
{
    public string? Resort { get; set; }
    public decimal? WoNumber { get; set; }
    public decimal? EscalationLevel { get; set; }
    public decimal? PageSeqNo { get; set; }
    public DateTime? LastPageReqDate { get; set; }
    public decimal? PageReqCount { get; set; }
    public string? ShiftId { get; set; }
    public DateTime? FirstPageReqDate { get; set; }
    public string? DeptId { get; set; }

    public virtual WorkOrders WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WorkorderPager>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.WoNumber, e.EscalationLevel })
                .HasName("QMS_WP_PK");

            entity.ToTable("WORKORDER_PAGER");

            entity.HasIndex(e => new { e.WoNumber, e.Resort })
                .HasName("QMS_WP_WO_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EscalationLevel)
                .HasColumnName("ESCALATION_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FirstPageReqDate)
                .HasColumnName("FIRST_PAGE_REQ_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.LastPageReqDate)
                .HasColumnName("LAST_PAGE_REQ_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PageReqCount)
                .HasColumnName("PAGE_REQ_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PageSeqNo)
                .HasColumnName("PAGE_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShiftId)
                .HasColumnName("SHIFT_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
			else
	            entity.HasOne(d => d.WorkOrders)
	                .WithMany(p => p.WorkorderPager)
	                .HasForeignKey(d => new { d.WoNumber, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("QMS_WP_WO_FK");
        });
	}
}
