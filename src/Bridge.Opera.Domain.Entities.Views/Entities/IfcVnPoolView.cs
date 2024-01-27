namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcVnPoolView
{
    public string Resort { get; set; }
    public string DbfLogo { get; set; }
    public int? RowNum { get; set; }
    public string LineType { get; set; }
    public string PoolIds { get; set; }
    public string PriorityPool { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcVnPoolView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_VN_POOL_VIEW");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(6)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LineType)
                .HasColumnName("LINE_TYPE")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PoolIds)
                .HasColumnName("POOL_IDS")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PriorityPool)
                .HasColumnName("PRIORITY_POOL")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowNum)
                .HasColumnName("ROW_NUM")
                .HasColumnType("NUMBER(6)")
                .ValueGeneratedOnAdd();
        });
	}
}
