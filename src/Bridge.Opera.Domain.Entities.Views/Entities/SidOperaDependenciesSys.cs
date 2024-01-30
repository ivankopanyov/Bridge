namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOperaDependenciesSys
{
    public string? TableName { get; set; }
    public string? ColumnName { get; set; }
    public string? ParentTableName { get; set; }
    public string? ParentColumnName { get; set; }
    public string? Filter { get; set; }
    public string? ForeignKeyYn { get; set; }
    public string? Remark { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOperaDependenciesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OPERA_DEPENDENCIES_SYS");

            entity.Property(e => e.ColumnName)
                .IsRequired()
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Filter)
                .HasColumnName("FILTER")
                .IsUnicode(false);

            entity.Property(e => e.ForeignKeyYn)
                .HasColumnName("FOREIGN_KEY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentColumnName)
                .IsRequired()
                .HasColumnName("PARENT_COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ParentTableName)
                .IsRequired()
                .HasColumnName("PARENT_TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
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
