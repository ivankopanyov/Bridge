namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcBatchRequests
{
    public string Resort { get; set; }
    public string RequestAction { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? Audsid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcBatchRequests>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_BATCH_REQUESTS");

            entity.HasIndex(e => new { e.RequestAction, e.InsertDate })
                .HasName("IFC_BATCH_IND");

            entity.Property(e => e.Audsid)
                .HasColumnName("AUDSID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestAction)
                .IsRequired()
                .HasColumnName("REQUEST_ACTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");
        });
	}
}
