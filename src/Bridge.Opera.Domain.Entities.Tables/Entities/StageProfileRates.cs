namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileRates
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? RateCode { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ResortRate { get; set; }
    public string? CommissionCode { get; set; }

    public virtual StageProfiles ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileRates>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_RATES");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId, e.RateCode })
                .HasName("STAGE_PROFILE_RATE_IDX1");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
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

            entity.Property(e => e.ResortRate)
                .HasColumnName("RESORT_RATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageProfiles)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.ResortNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_PROFILE_RATES_FK");
        });
	}
}
