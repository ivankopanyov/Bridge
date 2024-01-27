namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DayTypeRateOrder
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string DtCode { get; set; }
    public decimal? DisplaySequence { get; set; }

    public virtual RateHeader R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DayTypeRateOrder>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode, e.DtCode })
                .HasName("DAY_TYPE_RATE_ORDER_PK");

            entity.ToTable("DAY_TYPE_RATE_ORDER");

            entity.HasIndex(e => new { e.Resort, e.DisplaySequence, e.RateCode })
                .HasName("DAY_TYPE_RATE_ORDER_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtCode)
                .HasColumnName("DT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySequence)
                .HasColumnName("DISPLAY_SEQUENCE")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.DayTypeRateOrder)
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("DTRO_RATE_HEADER_FK");
        });
	}
}
