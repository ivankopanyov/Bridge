namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOperaAppDependenciesSys
{
    public string SourceTable { get; set; }
    public string TableName { get; set; }
    public string ColumnName { get; set; }
    public decimal? DependencySeq { get; set; }
    public string MsgKeyword { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOperaAppDependenciesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OPERA_APP_DEPENDENCIES_SYS");

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DependencySeq)
                .HasColumnName("DEPENDENCY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MsgKeyword)
                .HasColumnName("MSG_KEYWORD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceTable)
                .HasColumnName("SOURCE_TABLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
