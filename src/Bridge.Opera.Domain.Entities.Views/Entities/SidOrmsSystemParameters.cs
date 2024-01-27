namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOrmsSystemParameters
{
    public string Resort { get; set; }
    public string ConfigStatus { get; set; }
    public decimal? MaxLos { get; set; }
    public decimal? HurdleSteps { get; set; }
    public string AutoApplyYn { get; set; }
    public string AllotmentClassType { get; set; }
    public DateTime? NextFullrunDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOrmsSystemParameters>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ORMS_SYSTEM_PARAMETERS");

            entity.Property(e => e.AllotmentClassType)
                .HasColumnName("ALLOTMENT_CLASS_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.AutoApplyYn)
                .IsRequired()
                .HasColumnName("AUTO_APPLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConfigStatus)
                .HasColumnName("CONFIG_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.HurdleSteps)
                .HasColumnName("HURDLE_STEPS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxLos)
                .HasColumnName("MAX_LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NextFullrunDate)
                .HasColumnName("NEXT_FULLRUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
