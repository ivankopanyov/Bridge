namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfilePseudoCodes
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? PseudoCityCode { get; set; }
    public string? ChannelCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfilePseudoCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_PSEUDO_CODES");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId })
                .HasName("STAGE_PROFILE_PCC_IND1");

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

            entity.Property(e => e.PseudoCityCode)
                .HasColumnName("PSEUDO_CITY_CODE")
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
