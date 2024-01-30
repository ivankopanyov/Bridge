namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepMealTypeProgressBiFram
{
    public decimal? StatusListOrderBy { get; set; }
    public decimal? MonthOrderBy { get; set; }
    public decimal? LeftLabelOrderBy { get; set; }
    public string? StatusListLabel { get; set; }
    public string? YearLabel { get; set; }
    public string? LeftLabel { get; set; }
    public string? LeftLabelDy { get; set; }
    public string? LeftLabelMmDd { get; set; }
    public string? LeftLabelPmsPDtfm { get; set; }
    public string? LeftLabelType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepMealTypeProgressBiFram>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_MEAL_TYPE_PROGRESS_BI_FRAM");

            entity.Property(e => e.LeftLabel)
                .HasColumnName("LEFT_LABEL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LeftLabelDy)
                .HasColumnName("LEFT_LABEL_DY")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.LeftLabelMmDd)
                .HasColumnName("LEFT_LABEL_MM_DD")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.LeftLabelOrderBy)
                .HasColumnName("LEFT_LABEL_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeftLabelPmsPDtfm)
                .HasColumnName("LEFT_LABEL_PMS_P_DTFM")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.LeftLabelType)
                .HasColumnName("LEFT_LABEL_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MonthOrderBy)
                .HasColumnName("MONTH_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusListLabel)
                .HasColumnName("STATUS_LIST_LABEL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StatusListOrderBy)
                .HasColumnName("STATUS_LIST_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearLabel)
                .HasColumnName("YEAR_LABEL")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
