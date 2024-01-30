namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEspPhone
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? RecordType { get; set; }
    public string? PhoneIndicator { get; set; }
    public string? PhoneNumber { get; set; }
    public string? PhoneType { get; set; }
    public string? Extension { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEspPhone>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ESP_PHONE");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Extension)
                .HasColumnName("EXTENSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneIndicator)
                .HasColumnName("PHONE_INDICATOR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
