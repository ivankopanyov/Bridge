namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidFolioLayoutConfigSys
{
    public string FolioType { get; set; }
    public string RecordType { get; set; }
    public string RecordSubtype { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }
    public string UseInConfigYn { get; set; }
    public string CanDeleteYn { get; set; }
    public string DataType { get; set; }
    public string ColumnName { get; set; }
    public string FormatColumnYn { get; set; }
    public string BeginTag { get; set; }
    public string EndTag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidFolioLayoutConfigSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_FOLIO_LAYOUT_CONFIG_SYS");

            entity.Property(e => e.BeginTag)
                .HasColumnName("BEGIN_TAG")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndTag)
                .HasColumnName("END_TAG")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FormatColumnYn)
                .HasColumnName("FORMAT_COLUMN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordSubtype)
                .HasColumnName("RECORD_SUBTYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UseInConfigYn)
                .HasColumnName("USE_IN_CONFIG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
