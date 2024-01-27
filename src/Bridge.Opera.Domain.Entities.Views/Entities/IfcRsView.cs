namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcRsView
{
    public string Resort { get; set; }
    public string DbfLogo { get; set; }
    public int? RowNum { get; set; }
    public string Selector { get; set; }
    public string Status { get; set; }
    public string HskStatus { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcRsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_RS_VIEW");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(6)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HskStatus)
                .HasColumnName("HSK_STATUS")
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

            entity.Property(e => e.Selector)
                .HasColumnName("SELECTOR")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
