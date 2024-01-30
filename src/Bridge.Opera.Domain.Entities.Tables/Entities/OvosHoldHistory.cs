namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosHoldHistory
{
    public string? Resort { get; set; }
    public decimal? TrxNo { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Status { get; set; }
    public string? Reason { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosHoldHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OVOS_HOLD_HISTORY");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.Status })
                .HasName("OVOS_HOLD_RDS");

            entity.HasIndex(e => new { e.TrxNo, e.BusinessDate, e.Status })
                .HasName("OVOS_HOLD_TDS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason)
                .IsRequired()
                .HasColumnName("REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
