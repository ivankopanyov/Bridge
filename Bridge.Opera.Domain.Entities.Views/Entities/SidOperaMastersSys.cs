namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOperaMastersSys
{
    public string TableName { get; set; }
    public string ColumnName { get; set; }
    public string ColumnType { get; set; }
    public string SequenceName { get; set; }
    public string Remark { get; set; }
    public string Expression { get; set; }
    public string Filter { get; set; }
    public string RegenerateYn { get; set; }
    public string MappingExpression { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOperaMastersSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OPERA_MASTERS_SYS");

            entity.Property(e => e.ColumnName)
                .IsRequired()
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ColumnType)
                .IsRequired()
                .HasColumnName("COLUMN_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Expression)
                .HasColumnName("EXPRESSION")
                .IsUnicode(false);

            entity.Property(e => e.Filter)
                .HasColumnName("FILTER")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MappingExpression)
                .HasColumnName("MAPPING_EXPRESSION")
                .IsUnicode(false);

            entity.Property(e => e.RegenerateYn)
                .HasColumnName("REGENERATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .IsUnicode(false);

            entity.Property(e => e.SequenceName)
                .HasColumnName("SEQUENCE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
