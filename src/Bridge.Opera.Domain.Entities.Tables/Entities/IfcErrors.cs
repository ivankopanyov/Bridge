namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcErrors
{
    public string? Resort { get; set; }
    public decimal? RowId { get; set; }
    public string? ActionName { get; set; }
    public string? Error { get; set; }
    public string? Message { get; set; }
    public string? ResvNameId { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcErrors>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_ERRORS");

            entity.HasIndex(e => new { e.Resort, e.RowId, e.InsertDate })
                .HasName("IFC_ERRORS_RESRIDINSDT_IDX");

            entity.Property(e => e.ActionName)
                .HasColumnName("ACTION_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Error)
                .HasColumnName("ERROR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Message)
                .HasColumnName("MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RowId)
                .HasColumnName("ROW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
