namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsYielddistFullVw
{
    public string? Resort { get; set; }
    public string? YieldFlag { get; set; }
    public DateTime? TruncArrivalDate { get; set; }
    public decimal? Los { get; set; }
    public bool MilestoneId { get; set; }
    public string? Dowseason { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsYielddistFullVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_YIELDDIST_FULL_VW");

            entity.Property(e => e.Dowseason)
                .IsRequired()
                .HasColumnName("DOWSEASON")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MilestoneId).HasColumnName("MILESTONE_ID");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrivalDate)
                .HasColumnName("TRUNC_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.YieldFlag)
                .HasColumnName("YIELD_FLAG")
                .HasColumnType("CHAR(1)");
        });
	}
}
