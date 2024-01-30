namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMailLovSys
{
    public decimal? SourceId { get; set; }
    public string? TableName { get; set; }
    public string? FieldName { get; set; }
    public string? Description { get; set; }
    public string? LovQuery { get; set; }
    public string? MultiSelectYn { get; set; }
    public string? Column1Desc { get; set; }
    public string? Column2Desc { get; set; }
    public string? Column3Desc { get; set; }
    public decimal? ColumnNum { get; set; }
    public string? ResortColumn { get; set; }
    public string? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMailLovSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MAIL_LOV_SYS");

            entity.Property(e => e.Column1Desc)
                .HasColumnName("COLUMN1_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Column2Desc)
                .HasColumnName("COLUMN2_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Column3Desc)
                .HasColumnName("COLUMN3_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ColumnNum)
                .HasColumnName("COLUMN_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.LovQuery)
                .IsRequired()
                .HasColumnName("LOV_QUERY")
                .IsUnicode(false);

            entity.Property(e => e.MultiSelectYn)
                .HasColumnName("MULTI_SELECT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResortColumn)
                .HasColumnName("RESORT_COLUMN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
