namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpGbeResponseHeader
{
    public decimal? ExportId { get; set; }
    public string? GbeType { get; set; }
    public string? PropertyCode { get; set; }
    public string? RunType { get; set; }
    public DateTime? RequestDate { get; set; }
    public DateTime? RunDate { get; set; }
    public DateTime? RunTime { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpGbeResponseHeader>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_GBE_RESPONSE_HEADER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GbeType)
                .HasColumnName("GBE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RunDate)
                .HasColumnName("RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RunTime)
                .HasColumnName("RUN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.RunType)
                .HasColumnName("RUN_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
