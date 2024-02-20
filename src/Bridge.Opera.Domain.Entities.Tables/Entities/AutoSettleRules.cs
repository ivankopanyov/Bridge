namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AutoSettleRules
{
    public string? Resort { get; set; }
    public string? DefFolioStyle { get; set; }
    public string? FolioSettlementType { get; set; }
    public string? MoveToWinYn { get; set; }
    public decimal? AutoSettleDays { get; set; }
    public string? AutoSettleNaYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ResvAfsFlagYn { get; set; }
    public string? FolioView1Yn { get; set; }
    public string? FolioView2Yn { get; set; }
    public string? FolioView3Yn { get; set; }
    public string? FolioView4Yn { get; set; }
    public string? FolioView5Yn { get; set; }
    public string? FolioView6Yn { get; set; }
    public string? FolioView7Yn { get; set; }
    public string? FolioView8Yn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AutoSettleRules>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("AUTO_SETTLE_RULES_PK");

            entity.ToTable("AUTO_SETTLE_RULES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AutoSettleDays)
                .HasColumnName("AUTO_SETTLE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoSettleNaYn)
                .HasColumnName("AUTO_SETTLE_NA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefFolioStyle)
                .HasColumnName("DEF_FOLIO_STYLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioSettlementType)
                .HasColumnName("FOLIO_SETTLEMENT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioView1Yn)
                .HasColumnName("FOLIO_VIEW1_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView2Yn)
                .HasColumnName("FOLIO_VIEW2_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView3Yn)
                .HasColumnName("FOLIO_VIEW3_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView4Yn)
                .HasColumnName("FOLIO_VIEW4_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView5Yn)
                .HasColumnName("FOLIO_VIEW5_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView6Yn)
                .HasColumnName("FOLIO_VIEW6_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView7Yn)
                .HasColumnName("FOLIO_VIEW7_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView8Yn)
                .HasColumnName("FOLIO_VIEW8_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MoveToWinYn)
                .HasColumnName("MOVE_TO_WIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvAfsFlagYn)
                .HasColumnName("RESV_AFS_FLAG_YN")
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
