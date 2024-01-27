namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntResRateGc
{
    public string RateGcSeq { get; set; }
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string BlockCode { get; set; }
    public string GuaranteeClass { get; set; }
    public string CancelPolicy { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public string UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntResRateGc>(entity =>
        {
            entity.HasKey(e => e.RateGcSeq)
                .HasName("INT_RES_RATE_GC_PK");

            entity.ToTable("INT_RES_RATE_GC");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.BlockCode, e.BeginDate, e.EndDate })
                .HasName("INT_RES_RATE_GC_IDX2");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.BlockCode, e.GuaranteeClass, e.CancelPolicy })
                .HasName("INT_RES_RATE_GC_IDX1");

            entity.Property(e => e.RateGcSeq)
                .HasColumnName("RATE_GC_SEQ")
                .HasColumnType("NCHAR(30)");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancelPolicy)
                .IsRequired()
                .HasColumnName("CANCEL_POLICY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuaranteeClass)
                .IsRequired()
                .HasColumnName("GUARANTEE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .IsRequired()
                .HasColumnName("INSERT_USER")
                .HasColumnType("NCHAR(20)");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .IsRequired()
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NCHAR(20)");
        });
	}
}
