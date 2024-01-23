namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiSizingDtl
{
    public decimal SizingId { get; set; }
    public string ValueType { get; set; }
    public string ValueName { get; set; }
    public decimal ValueSeq { get; set; }
    public string Value { get; set; }
    public string ValueDatatype { get; set; }
    public string ValueFormat { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiSizingDtl>(entity =>
        {
            entity.HasKey(e => new { e.SizingId, e.ValueType, e.ValueName, e.ValueSeq })
                .HasName("OBI_SIZING_DTL_PK");

            entity.ToTable("OBI_SIZING_DTL");

            entity.Property(e => e.SizingId)
                .HasColumnName("SIZING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValueType)
                .HasColumnName("VALUE_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ValueName)
                .HasColumnName("VALUE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ValueSeq)
                .HasColumnName("VALUE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .IsUnicode(false);

            entity.Property(e => e.ValueDatatype)
                .HasColumnName("VALUE_DATATYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ValueFormat)
                .HasColumnName("VALUE_FORMAT")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
