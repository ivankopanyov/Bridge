namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScDemandDates
{
    public string? Resort { get; set; }
    public string? DtCode { get; set; }
    public DateTime? DtDate { get; set; }

    public virtual ScDemandDayType ScDemandDayType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScDemandDates>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DtCode, e.DtDate })
                .HasName("SCDD_PK");

            entity.ToTable("SC_DEMAND_DATES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtCode)
                .HasColumnName("DT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtDate)
                .HasColumnName("DT_DATE")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(ScDemandDayType)))
				entity.Ignore(e => e.ScDemandDayType);
			else
	            entity.HasOne(d => d.ScDemandDayType)
	                .WithMany(p => p.ScDemandDates)
	                .HasForeignKey(d => new { d.Resort, d.DtCode })
	                .HasConstraintName("SCDD_SCDDT_FK");
        });
	}
}
