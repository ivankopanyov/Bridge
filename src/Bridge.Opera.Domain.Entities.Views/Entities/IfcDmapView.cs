namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcDmapView
{
    public string? Resort { get; set; }
    public string? DbfLogo { get; set; }
    public int? RowNum { get; set; }
    public string? PStation { get; set; }
    public string? DlsId { get; set; }
    public string? Location { get; set; }
    public string? Etype { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcDmapView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_DMAP_VIEW");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(6)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DlsId)
                .HasColumnName("DLS_ID")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Etype)
                .HasColumnName("ETYPE")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Location)
                .HasColumnName("LOCATION")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PStation)
                .HasColumnName("P_STATION")
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
