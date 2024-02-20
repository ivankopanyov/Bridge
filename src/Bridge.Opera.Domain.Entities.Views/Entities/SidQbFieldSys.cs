namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidQbFieldSys
{
    public string? EntityName { get; set; }
    public string? FieldName { get; set; }
    public string? FieldLabel { get; set; }
    public string? FieldDesc { get; set; }
    public string? BaseColumn { get; set; }
    public string? DataType { get; set; }
    public string? FieldLov { get; set; }
    public string? IdxLeadYn { get; set; }
    public string? IdxPartYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidQbFieldSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_QB_FIELD_SYS");

            entity.Property(e => e.BaseColumn)
                .HasColumnName("BASE_COLUMN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EntityName)
                .IsRequired()
                .HasColumnName("ENTITY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldDesc)
                .HasColumnName("FIELD_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FieldLabel)
                .HasColumnName("FIELD_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldLov)
                .HasColumnName("FIELD_LOV")
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IdxLeadYn)
                .HasColumnName("IDX_LEAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IdxPartYn)
                .HasColumnName("IDX_PART_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
