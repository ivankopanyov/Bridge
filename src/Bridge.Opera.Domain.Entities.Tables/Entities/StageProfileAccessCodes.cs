namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileAccessCodes
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? RateCode { get; set; }
    public string? ChannelCode { get; set; }
    public string? AccessCode { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? AccessChannelCode { get; set; }
    public decimal? AccessCodeSeqno { get; set; }
    public string? AllResortsYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileAccessCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_ACCESS_CODES");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId })
                .HasName("STAGE_PROFILE_ACCESS_CODE");

            entity.Property(e => e.AccessChannelCode)
                .HasColumnName("ACCESS_CHANNEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccessCode)
                .HasColumnName("ACCESS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccessCodeSeqno)
                .HasColumnName("ACCESS_CODE_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllResortsYn)
                .HasColumnName("ALL_RESORTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChannelCode)
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
