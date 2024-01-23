namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PartsUsed
{
    public decimal? PartsCost { get; set; }
    public decimal Qty { get; set; }
    public decimal WoNumber { get; set; }
    public string Resort { get; set; }
    public string PartCode { get; set; }
    public decimal PartsUsedSeqNo { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal UserId { get; set; }
    public DateTime PartsUsedDate { get; set; }

    public virtual SpareParts SpareParts { get; set; }
    public virtual WorkOrders WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PartsUsed>(entity =>
        {
            entity.HasKey(e => e.PartsUsedSeqNo)
                .HasName("PU_PK");

            entity.ToTable("PARTS_USED");

            entity.HasIndex(e => new { e.Resort, e.PartCode })
                .HasName("PU_SP_FK_I");

            entity.HasIndex(e => new { e.WoNumber, e.Resort })
                .HasName("PU_WO_FK_I");

            entity.Property(e => e.PartsUsedSeqNo)
                .HasColumnName("PARTS_USED_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PartCode)
                .IsRequired()
                .HasColumnName("PART_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PartsCost)
                .HasColumnName("PARTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartsUsedDate)
                .HasColumnName("PARTS_USED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Qty)
                .HasColumnName("QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(SpareParts)))
				entity.Ignore(e => e.SpareParts);
			else
	            entity.HasOne(d => d.SpareParts)
	                .WithMany(p => p.PartsUsed)
	                .HasForeignKey(d => new { d.Resort, d.PartCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PU_SP_FK");

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
			else
	            entity.HasOne(d => d.WorkOrders)
	                .WithMany(p => p.PartsUsed)
	                .HasForeignKey(d => new { d.WoNumber, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PU_WO_FK");
        });
	}
}
