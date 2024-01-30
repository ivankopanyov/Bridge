namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaShell
{
    public string? Name { get; set; }
    public string? Version { get; set; }
    public DateTime? UploadDate { get; set; }
    public string? SysLob { get; set; }
    public string? CroLob { get; set; }
    public string? ChnLob { get; set; }
    public string? PrpLob { get; set; }
    public string? RepLob { get; set; }
    public int? Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaShell>(entity =>
        {
            entity.HasKey(e => e.Name)
                .HasName("OSL_PK");

            entity.ToTable("OPERA_SHELL");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChnLob)
                .HasColumnName("CHN_LOB")
                .HasColumnType("CLOB");

            entity.Property(e => e.CroLob)
                .HasColumnName("CRO_LOB")
                .HasColumnType("CLOB");

            entity.Property(e => e.PrpLob)
                .HasColumnName("PRP_LOB")
                .HasColumnType("CLOB");

            entity.Property(e => e.RepLob)
                .HasColumnName("REP_LOB")
                .HasColumnType("CLOB");

            entity.Property(e => e.Status).HasColumnName("STATUS");

            entity.Property(e => e.SysLob)
                .HasColumnName("SYS_LOB")
                .HasColumnType("CLOB");

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
