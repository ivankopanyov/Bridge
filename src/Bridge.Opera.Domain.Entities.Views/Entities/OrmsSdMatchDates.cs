namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsSdMatchDates
{
    public decimal? Id { get; set; }
    public string? RecType { get; set; }
    public decimal? CalId { get; set; }
    public string? Resort { get; set; }
    public DateTime? StayDate { get; set; }
    public DateTime? MatchDate { get; set; }
    public string? Dowseason { get; set; }
    public decimal? Rnk { get; set; }
    public decimal? Maxrnk { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsSdMatchDates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_SD_MATCH_DATES");

            entity.Property(e => e.CalId)
                .HasColumnName("CAL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dowseason)
                .HasColumnName("DOWSEASON")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MatchDate)
                .HasColumnName("MATCH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Maxrnk)
                .HasColumnName("MAXRNK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecType)
                .HasColumnName("REC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Rnk)
                .HasColumnName("RNK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");
        });
	}
}
