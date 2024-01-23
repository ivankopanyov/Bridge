namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpGrsStatistics
{
    public string RoomCategoryLabel { get; set; }
    public string Reward { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? GtdSatisfied { get; set; }
    public decimal? RqstSatisfied { get; set; }
    public decimal? GtdNotsatisfied { get; set; }
    public decimal? RqstNotsatisfied { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpGrsStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_GRS_STATISTICS");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GtdNotsatisfied)
                .HasColumnName("GTD_NOTSATISFIED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdSatisfied)
                .HasColumnName("GTD_SATISFIED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reward)
                .HasColumnName("REWARD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RqstNotsatisfied)
                .HasColumnName("RQST_NOTSATISFIED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RqstSatisfied)
                .HasColumnName("RQST_SATISFIED")
                .HasColumnType("NUMBER");
        });
	}
}
