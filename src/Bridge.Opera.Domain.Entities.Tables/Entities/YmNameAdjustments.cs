namespace Bridge.Opera.Domain.Entities.Tables;

public partial class YmNameAdjustments
{
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }
    public string? AdjustmentCode { get; set; }
    public decimal? AdjustmentAmount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual Name Name { get; set; }
    public virtual YmAdjustmentCodes YmAdjustmentCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<YmNameAdjustments>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.NameId, e.AdjustmentCode })
                .HasName("YM_NAME_ADJUSTMENTS_PK");

            entity.ToTable("YM_NAME_ADJUSTMENTS");

            entity.HasIndex(e => e.NameId)
                .HasName("YN_NAME_ADJUSTMENT_IDX");

            entity.HasIndex(e => new { e.Resort, e.AdjustmentCode })
                .HasName("YN_NAME_ADJUSTMENTCODE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustmentCode)
                .HasColumnName("ADJUSTMENT_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.AdjustmentAmount)
                .HasColumnName("ADJUSTMENT_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.YmNameAdjustments)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("YM_NAME_ADJUSTMENTS_NAME_FK");

			if (!types.Contains(typeof(YmAdjustmentCodes)))
				entity.Ignore(e => e.YmAdjustmentCodes);
			else
	            entity.HasOne(d => d.YmAdjustmentCodes)
	                .WithMany(p => p.YmNameAdjustments)
	                .HasForeignKey(d => new { d.Resort, d.AdjustmentCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("YM_NAME_YM_ADJUSTMENT_FK");
        });
	}
}
