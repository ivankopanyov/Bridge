namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PromoSpecialServices
{
    public decimal? PromoSeqId { get; set; }
    public string? Resort { get; set; }
    public string? SpecialRequestCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Frequency { get; set; }
    public string? ServiceDesc { get; set; }

    public virtual Promotions PromoSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PromoSpecialServices>(entity =>
        {
            entity.HasKey(e => new { e.PromoSeqId, e.Resort, e.SpecialRequestCode })
                .HasName("PROMO_SPECIAL_SERVICES_PK");

            entity.ToTable("PROMO_SPECIAL_SERVICES");

            entity.Property(e => e.PromoSeqId)
                .HasColumnName("PROMO_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SpecialRequestCode)
                .HasColumnName("SPECIAL_REQUEST_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServiceDesc)
                .HasColumnName("SERVICE_DESC")
                .HasMaxLength(50)
                .IsUnicode(false);

			if (!types.Contains(typeof(Promotions)))
				entity.Ignore(e => e.PromoSeq);
			else
	            entity.HasOne(d => d.PromoSeq)
	                .WithMany(p => p.PromoSpecialServices)
	                .HasForeignKey(d => d.PromoSeqId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PROMO_SPECIAL_SERVICES_FK");
        });
	}
}
