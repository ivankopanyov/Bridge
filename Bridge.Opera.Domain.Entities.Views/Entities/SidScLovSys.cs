namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidScLovSys
{
    public string TableName { get; set; }
    public string FieldName { get; set; }
    public string UdfName { get; set; }
    public string SpMode { get; set; }
    public string FormName { get; set; }
    public string LovQuery { get; set; }
    public string Column1Desc { get; set; }
    public string Column2Desc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidScLovSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_SC$LOV_SYS");

            entity.Property(e => e.Column1Desc)
                .HasColumnName("COLUMN1_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Column2Desc)
                .HasColumnName("COLUMN2_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LovQuery)
                .HasColumnName("LOV_QUERY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SpMode)
                .HasColumnName("SP_MODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.UdfName)
                .HasColumnName("UDF_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
