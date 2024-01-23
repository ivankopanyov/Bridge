namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAllotmentQuotOffset
{
    public string BlockCode { get; set; }
    public string Resort { get; set; }
    public string OffsetCode { get; set; }
    public decimal? Offset { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? OffsetAmt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAllotmentQuotOffset>(entity =>
        {
            entity.HasKey(e => new { e.BlockCode, e.Resort, e.OffsetCode })
                .HasName("ORMS_ALLOT_QUOT_OFF_PK");

            entity.ToTable("ORMS_ALLOTMENT_QUOT_OFFSET");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OffsetCode)
                .HasColumnName("OFFSET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Offset)
                .HasColumnName("OFFSET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetAmt)
                .HasColumnName("OFFSET_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
