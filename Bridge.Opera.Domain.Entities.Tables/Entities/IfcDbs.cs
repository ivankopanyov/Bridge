namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcDbs
{
    public string DbfLogo { get; set; }
    public string Type { get; set; }
    public string Field { get; set; }
    public string Data { get; set; }
    public int? RowNum { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcDbs>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_DBS");

            entity.HasIndex(e => new { e.Resort, e.DbfLogo, e.Type })
                .HasName("IFC_DBS_IDX");

            entity.Property(e => e.Data)
                .HasColumnName("DATA")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.Field)
                .HasColumnName("FIELD")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowNum)
                .HasColumnName("ROW_NUM")
                .HasColumnType("NUMBER(6)");

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
