namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MassRateRefDetail
{
    public decimal MassRateRefId { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime ResvDate { get; set; }
    public decimal PreviousRate { get; set; }
    public decimal NewRate { get; set; }
    public string RateCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MassRateRefDetail>(entity =>
        {
            entity.HasKey(e => new { e.MassRateRefId, e.Resort, e.ResvNameId, e.ResvDate })
                .HasName("MASS_RATE_REF_DET_PK");

            entity.ToTable("MASS_RATE_REF_DETAIL");

            entity.Property(e => e.MassRateRefId)
                .HasColumnName("MASS_RATE_REF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvDate)
                .HasColumnName("RESV_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NewRate)
                .HasColumnName("NEW_RATE")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0                     ");

            entity.Property(e => e.PreviousRate)
                .HasColumnName("PREVIOUS_RATE")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0                     ");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
