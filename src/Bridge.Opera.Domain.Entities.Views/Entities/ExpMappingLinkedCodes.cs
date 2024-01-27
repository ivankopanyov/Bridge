namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpMappingLinkedCodes
{
    public string ConfigType { get; set; }
    public string Resort { get; set; }
    public string LinkedCode { get; set; }
    public decimal ExpMappingId { get; set; }
    public string MappingType { get; set; }
    public string TypeDesc { get; set; }
    public string MappingCode { get; set; }
    public string CodeDesc { get; set; }
    public string DataType { get; set; }
    public decimal? SeqNo { get; set; }
    public string UseLovYn { get; set; }
    public string LovName { get; set; }
    public string RequiredYn { get; set; }
    public string ExportValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpMappingLinkedCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_MAPPING_LINKED_CODES");

            entity.Property(e => e.CodeDesc)
                .HasColumnName("CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ConfigType)
                .HasColumnName("CONFIG_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ExpMappingId)
                .HasColumnName("EXP_MAPPING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportValue)
                .HasColumnName("EXPORT_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LinkedCode)
                .HasColumnName("LINKED_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LovName)
                .HasColumnName("LOV_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MappingCode)
                .IsRequired()
                .HasColumnName("MAPPING_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MappingType)
                .IsRequired()
                .HasColumnName("MAPPING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequiredYn)
                .HasColumnName("REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TypeDesc)
                .HasColumnName("TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UseLovYn)
                .HasColumnName("USE_LOV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
