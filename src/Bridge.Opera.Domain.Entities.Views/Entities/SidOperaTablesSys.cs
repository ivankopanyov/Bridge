namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOperaTablesSys
{
    public string TableName { get; set; }
    public string TableScope { get; set; }
    public string TableType { get; set; }
    public string MigrateYn { get; set; }
    public string Filter { get; set; }
    public string Remark { get; set; }
    public string Owner { get; set; }
    public string Module { get; set; }
    public decimal? OrderBy { get; set; }
    public string PrimaryKey { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string DowntimeFilter { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOperaTablesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OPERA_TABLES_SYS");

            entity.Property(e => e.DowntimeFilter)
                .HasColumnName("DOWNTIME_FILTER")
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

            entity.Property(e => e.MigrateYn)
                .IsRequired()
                .HasColumnName("MIGRATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryKey)
                .HasColumnName("PRIMARY_KEY")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TableScope)
                .IsRequired()
                .HasColumnName("TABLE_SCOPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.TableType)
                .IsRequired()
                .HasColumnName("TABLE_TYPE")
                .HasMaxLength(3)
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
