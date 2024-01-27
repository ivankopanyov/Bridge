namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidResetDataSys
{
    public string TableName { get; set; }
    public string Description { get; set; }
    public string IncludeYn { get; set; }
    public string ResortColumnName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidResetDataSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RESET_DATA_SYS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IncludeYn)
                .HasColumnName("INCLUDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResortColumnName)
                .HasColumnName("RESORT_COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
