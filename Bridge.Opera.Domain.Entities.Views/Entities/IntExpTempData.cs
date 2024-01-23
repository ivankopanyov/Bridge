namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntExpTempData
{
    public decimal ExpTempId { get; set; }
    public decimal? ExpFileId { get; set; }
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public string ExpClobData { get; set; }
    public DateTime? DataDate { get; set; }
    public string IfcExpType { get; set; }
    public string UploadType { get; set; }
    public string OxiFileName { get; set; }
    public DateTime? GeneratedBusinessDate { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntExpTempData>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_EXP_TEMP_DATA");

            entity.Property(e => e.DataDate)
                .HasColumnName("DATA_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpClobData)
                .HasColumnName("EXP_CLOB_DATA")
                .HasColumnType("CLOB");

            entity.Property(e => e.ExpFileId)
                .HasColumnName("EXP_FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpTempId)
                .HasColumnName("EXP_TEMP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GeneratedBusinessDate)
                .HasColumnName("GENERATED_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IfcExpType)
                .HasColumnName("IFC_EXP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OxiFileName)
                .HasColumnName("OXI_FILE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UploadType)
                .HasColumnName("UPLOAD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
