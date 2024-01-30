namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PromoInformation
{
    public decimal? PromoSeqId { get; set; }
    public string? InfoType { get; set; }
    public decimal? InfoSeqNo { get; set; }
    public string? InfoText { get; set; }
    public string? InfoDesc { get; set; }
    public decimal? InfoDescSeqNbr { get; set; }

    public virtual Promotions PromoSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PromoInformation>(entity =>
        {
            entity.HasKey(e => new { e.PromoSeqId, e.InfoType, e.InfoSeqNo })
                .HasName("PROMO_INFORMATION_PK");

            entity.ToTable("PROMO_INFORMATION");

            entity.Property(e => e.PromoSeqId)
                .HasColumnName("PROMO_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InfoType)
                .HasColumnName("INFO_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'D'");

            entity.Property(e => e.InfoSeqNo)
                .HasColumnName("INFO_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InfoDesc)
                .IsRequired()
                .HasColumnName("INFO_DESC")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InfoDescSeqNbr)
                .HasColumnName("INFO_DESC_SEQ_NBR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InfoText)
                .HasColumnName("INFO_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(Promotions)))
				entity.Ignore(e => e.PromoSeq);
			else
	            entity.HasOne(d => d.PromoSeq)
	                .WithMany(p => p.PromoInformationNavigation)
	                .HasForeignKey(d => d.PromoSeqId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PROMO_INFORMATION_FK");
        });
	}
}
