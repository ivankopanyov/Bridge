namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NightAuditCheck
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RoomPYn { get; set; }
    public string? FixChargesPYn { get; set; }
    public string? PackagePYn { get; set; }
    public string? ProfitLossPYn { get; set; }
    public decimal? LatestPost { get; set; }
    public decimal? LatestGuest { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Errors { get; set; }
    public string? ProformaYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NightAuditCheck>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BusinessDate, e.ResvNameId })
                .HasName("NAC_PK");

            entity.ToTable("NIGHT_AUDIT_CHECK");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Errors)
                .HasColumnName("ERRORS")
                .IsUnicode(false);

            entity.Property(e => e.FixChargesPYn)
                .HasColumnName("FIX_CHARGES_P_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LatestGuest)
                .HasColumnName("LATEST_GUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LatestPost)
                .HasColumnName("LATEST_POST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackagePYn)
                .HasColumnName("PACKAGE_P_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProfitLossPYn)
                .HasColumnName("PROFIT_LOSS_P_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ProformaYn)
                .HasColumnName("PROFORMA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomPYn)
                .HasColumnName("ROOM_P_YN")
                .HasMaxLength(1)
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
