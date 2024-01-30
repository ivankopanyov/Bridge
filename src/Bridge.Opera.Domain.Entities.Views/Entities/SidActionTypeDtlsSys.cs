namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidActionTypeDtlsSys
{
    public string? Module { get; set; }
    public string? ActionType { get; set; }
    public string? DataElement { get; set; }
    public string? UsageContext { get; set; }
    public string? DataElementDatatype { get; set; }
    public decimal? LovSequence { get; set; }
    public string? Xmltagname { get; set; }
    public string? Grpxmltagname { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidActionTypeDtlsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ACTION_TYPE_DTLS_SYS");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DataElement)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DataElementDatatype)
                .HasColumnName("DATA_ELEMENT_DATATYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Grpxmltagname)
                .HasColumnName("GRPXMLTAGNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LovSequence)
                .HasColumnName("LOV_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UsageContext)
                .HasColumnName("USAGE_CONTEXT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Xmltagname)
                .HasColumnName("XMLTAGNAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
