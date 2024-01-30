namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsHistVw
{
    public string? Resort { get; set; }
    public string? YieldFlag { get; set; }
    public DateTime? PastArrival { get; set; }
    public DateTime? TruncArrival { get; set; }
    public decimal? Los { get; set; }
    public bool MilestoneId { get; set; }
    public decimal? Cnt { get; set; }
    public decimal? Rn { get; set; }
    public decimal? S1 { get; set; }
    public decimal? S2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsHistVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_HIST_VW");

            entity.Property(e => e.Cnt)
                .HasColumnName("CNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MilestoneId).HasColumnName("MILESTONE_ID");

            entity.Property(e => e.PastArrival)
                .HasColumnName("PAST_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Rn)
                .HasColumnName("RN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.S1).HasColumnType("NUMBER");

            entity.Property(e => e.S2).HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.YieldFlag)
                .HasColumnName("YIELD_FLAG")
                .HasColumnType("CHAR(1)");
        });
	}
}
