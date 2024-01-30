namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppUsergrpTrxcode
{
    public string? Resort { get; set; }
    public decimal? AppUserId { get; set; }
    public string? TrxCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppUsergrpTrxcode>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AppUserId, e.TrxCode })
                .HasName("AUTRX_PK");

            entity.ToTable("APP_USERGRP_TRXCODE");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("AUTRX_RESTRX_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
