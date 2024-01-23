namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidAppModuleDetails
{
    public decimal? AppModuleId { get; set; }
    public string ParameterName { get; set; }
    public string ParameterValue { get; set; }
    public decimal? OrderBy { get; set; }
    public string DataType { get; set; }
    public string ParameterLabel { get; set; }
    public string DateFormatMask { get; set; }
    public string LovSql { get; set; }
    public string LovValidate { get; set; }
    public decimal? Offset { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidAppModuleDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_APP_MODULE_DETAILS");

            entity.Property(e => e.AppModuleId)
                .HasColumnName("APP_MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DateFormatMask)
                .HasColumnName("DATE_FORMAT_MASK")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LovSql)
                .HasColumnName("LOV_SQL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LovValidate)
                .HasColumnName("LOV_VALIDATE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Offset)
                .HasColumnName("OFFSET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParameterLabel)
                .HasColumnName("PARAMETER_LABEL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .IsUnicode(false);
        });
	}
}
