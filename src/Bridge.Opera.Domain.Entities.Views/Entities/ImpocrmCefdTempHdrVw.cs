namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ImpocrmCefdTempHdrVw
{
    public decimal? BatchId { get; set; }
    public string? InterfaceId { get; set; }
    public DateTime? ImportStartDate { get; set; }
    public DateTime? ImportEndDate { get; set; }
    public decimal? NewCount { get; set; }
    public decimal? ProcessedCount { get; set; }
    public decimal? ErrorCount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ImpocrmCefdTempHdrVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IMPOCRM_CEFD_TEMP_HDR_VW");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ErrorCount)
                .HasColumnName("ERROR_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ImportEndDate)
                .HasColumnName("IMPORT_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImportStartDate)
                .HasColumnName("IMPORT_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NewCount)
                .HasColumnName("NEW_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessedCount)
                .HasColumnName("PROCESSED_COUNT")
                .HasColumnType("NUMBER");
        });
	}
}
