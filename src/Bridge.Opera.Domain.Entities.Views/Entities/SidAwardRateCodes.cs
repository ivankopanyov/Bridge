namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidAwardRateCodes
{
    public decimal? AwardSeqId { get; set; }
    public string? Resort { get; set; }
    public string? AwardCode { get; set; }
    public string? RateCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidAwardRateCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_AWARD_RATE_CODES");

            entity.Property(e => e.AwardCode)
                .IsRequired()
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardSeqId)
                .HasColumnName("AWARD_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
