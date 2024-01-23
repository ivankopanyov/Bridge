namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSpaceLinks
{
    public decimal? RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public string BusinessDate { get; set; }
    public string ComboElement { get; set; }
    public string ComboRoom { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSpaceLinks>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SPACE_LINKS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ComboElement)
                .HasColumnName("COMBO_ELEMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComboRoom)
                .HasColumnName("COMBO_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");
        });
	}
}
