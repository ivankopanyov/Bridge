namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileAcscdResorts
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public decimal AccessCdSeqno { get; set; }
    public string ExtResortCode { get; set; }
    public string OperaResortCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileAcscdResorts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId, e.AccessCdSeqno, e.ExtResortCode })
                .HasName("SPAC_PK");

            entity.ToTable("STAGE_PROFILE_ACSCD_RESORTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccessCdSeqno)
                .HasColumnName("ACCESS_CD_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtResortCode)
                .HasColumnName("EXT_RESORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OperaResortCode)
                .HasColumnName("OPERA_RESORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
