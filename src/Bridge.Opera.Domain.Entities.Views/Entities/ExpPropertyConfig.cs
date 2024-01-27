namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpPropertyConfig
{
    public string RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string Resort { get; set; }
    public string AlternateResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpPropertyConfig>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_PROPERTY_CONFIG");

            entity.Property(e => e.AlternateResort)
                .HasColumnName("ALTERNATE_RESORT")
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");
        });
	}
}
