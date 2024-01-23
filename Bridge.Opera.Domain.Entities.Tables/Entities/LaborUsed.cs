namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LaborUsed
{
    public decimal DurationWorked { get; set; }
    public decimal? LaborCost { get; set; }
    public decimal UserId { get; set; }
    public decimal WoNumber { get; set; }
    public string Resort { get; set; }
    public string UotCode { get; set; }
    public decimal LaborUsedSeqNo { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? HourlyRate { get; set; }
    public DateTime LaborUsedDate { get; set; }

    public virtual UnitOfTime UnitOfTime { get; set; }
    public virtual WorkOrders WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LaborUsed>(entity =>
        {
            entity.HasKey(e => e.LaborUsedSeqNo)
                .HasName("LABOR_USED_PK");

            entity.ToTable("LABOR_USED");

            entity.HasIndex(e => new { e.UotCode, e.Resort })
                .HasName("LABOR_USED_UOT_FK_I");

            entity.HasIndex(e => new { e.WoNumber, e.Resort })
                .HasName("LABOR_USED_WO_FK_I");

            entity.Property(e => e.LaborUsedSeqNo)
                .HasColumnName("LABOR_USED_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DurationWorked)
                .HasColumnName("DURATION_WORKED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HourlyRate)
                .HasColumnName("HOURLY_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LaborCost)
                .HasColumnName("LABOR_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LaborUsedDate)
                .HasColumnName("LABOR_USED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UotCode)
                .IsRequired()
                .HasColumnName("UOT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(UnitOfTime)))
				entity.Ignore(e => e.UnitOfTime);
			else
	            entity.HasOne(d => d.UnitOfTime)
	                .WithMany(p => p.LaborUsed)
	                .HasForeignKey(d => new { d.UotCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("LABOR_USED_UOT_FK");

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
			else
	            entity.HasOne(d => d.WorkOrders)
	                .WithMany(p => p.LaborUsed)
	                .HasForeignKey(d => new { d.WoNumber, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("LABOR_USED_WO_FK");
        });
	}
}
