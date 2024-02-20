namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcCallAcctTime
{
    public decimal? TimeId { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public decimal? StartTime { get; set; }
    public decimal? EndTime { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcCallAcctTime>(entity =>
        {
            entity.HasKey(e => e.TimeId)
                .HasName("IFCCAT_PK");

            entity.ToTable("IFC_CALL_ACCT_TIME");

            entity.HasIndex(e => new { e.IfcCtrlId, e.TimeId })
                .HasName("IFC_CALL_ACCT_TIME_IDX");

            entity.Property(e => e.TimeId)
                .HasColumnName("TIME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("NUMBER");
        });
	}
}
