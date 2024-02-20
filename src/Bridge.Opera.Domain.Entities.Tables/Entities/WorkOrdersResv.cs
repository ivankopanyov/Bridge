namespace Bridge.Opera.Domain.Entities.Tables;

public partial class WorkOrdersResv
{
    public string? Resort { get; set; }
    public decimal? WoNumber { get; set; }
    public decimal? ResvNameId { get; set; }

    public virtual WorkOrders WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WorkOrdersResv>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.WoNumber, e.ResvNameId })
                .HasName("WOR_PK");

            entity.ToTable("WORK_ORDERS_RESV");

            entity.HasIndex(e => new { e.WoNumber, e.Resort })
                .HasName("WOR_WONUMBER_IDX");

            entity.HasIndex(e => new { e.ResvNameId, e.Resort, e.WoNumber })
                .HasName("WOR_RESV_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
			else
	            entity.HasOne(d => d.WorkOrders)
	                .WithMany(p => p.WorkOrdersResv)
	                .HasForeignKey(d => new { d.WoNumber, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("WOR_WO_FK");
        });
	}
}
