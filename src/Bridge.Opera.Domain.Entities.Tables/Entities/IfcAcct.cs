namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcAcct
{
    public string? Resort { get; set; }
    public string? Selector { get; set; }
    public string? Acct { get; set; }
    public string? Text { get; set; }
    public string? DbfLogo { get; set; }
    public string? Flag { get; set; }
    public decimal? Id { get; set; }
    public string? SalesOutlet { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcAcct>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_ACCT");

            entity.HasIndex(e => new { e.Resort, e.DbfLogo, e.Selector })
                .HasName("IFC_ACCT_RES_DBF_SEL_IDX");

            entity.Property(e => e.Acct)
                .HasColumnName("ACCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Flag)
                .HasColumnName("FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SalesOutlet)
                .HasColumnName("SALES_OUTLET")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Selector)
                .HasColumnName("SELECTOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
