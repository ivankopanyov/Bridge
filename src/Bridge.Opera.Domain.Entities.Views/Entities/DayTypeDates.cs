namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DayTypeDates
{
    public DateTime DtDate { get; set; }
    public string DtCode { get; set; }
    public decimal? RankValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DayTypeDates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DAY_TYPE_DATES");

            entity.Property(e => e.DtCode)
                .HasColumnName("DT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtDate)
                .HasColumnName("DT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RankValue)
                .HasColumnName("RANK_VALUE")
                .HasColumnType("NUMBER");
        });
	}
}
