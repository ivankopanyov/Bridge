namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScDemandDatesView
{
    public string Resort { get; set; }
    public string DtCode { get; set; }
    public string Description { get; set; }
    public DateTime DtDate { get; set; }
    public string DisplayColor { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScDemandDatesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_DEMAND_DATES_VIEW");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DtCode)
                .IsRequired()
                .HasColumnName("DT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtDate)
                .HasColumnName("DT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
