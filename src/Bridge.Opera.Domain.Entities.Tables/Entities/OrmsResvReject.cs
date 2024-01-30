namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsResvReject
{
    public string? Resort { get; set; }
    public byte CapacityPct { get; set; }
    public decimal? TotalRejection { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsResvReject>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ORMS_RESV_REJECT");

            entity.HasIndex(e => new { e.Resort, e.CapacityPct })
                .HasName("ORMS_RESV_REJ_IDX");

            entity.Property(e => e.CapacityPct).HasColumnName("CAPACITY_PCT");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalRejection)
                .HasColumnName("TOTAL_REJECTION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
