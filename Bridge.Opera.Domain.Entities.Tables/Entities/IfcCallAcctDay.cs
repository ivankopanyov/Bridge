namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcCallAcctDay
{
    public decimal? IfcCtrlId { get; set; }
    public decimal DayId { get; set; }
    public decimal? StartDay { get; set; }
    public decimal? EndDay { get; set; }
    public DateTime? SpecialDate { get; set; }
    public string DateDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcCallAcctDay>(entity =>
        {
            entity.HasKey(e => e.DayId)
                .HasName("IFCCAD_PK");

            entity.ToTable("IFC_CALL_ACCT_DAY");

            entity.HasIndex(e => new { e.IfcCtrlId, e.DayId })
                .HasName("IFC_CALL_ACCT_DAY_IDX");

            entity.Property(e => e.DayId)
                .HasColumnName("DAY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateDesc)
                .HasColumnName("DATE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDay)
                .HasColumnName("END_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpecialDate)
                .HasColumnName("SPECIAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StartDay)
                .HasColumnName("START_DAY")
                .HasColumnType("NUMBER");
        });
	}
}
