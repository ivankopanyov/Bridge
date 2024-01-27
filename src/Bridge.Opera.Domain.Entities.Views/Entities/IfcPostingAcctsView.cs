namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcPostingAcctsView
{
    public decimal? Id { get; set; }
    public string Resort { get; set; }
    public string DbfLogo { get; set; }
    public string Selector { get; set; }
    public string SalesOutlet { get; set; }
    public string Acct { get; set; }
    public string AcctDesc { get; set; }
    public string Flag { get; set; }
    public string DpCode { get; set; }
    public string DeptDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcPostingAcctsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_POSTING_ACCTS_VIEW");

            entity.Property(e => e.Acct)
                .HasColumnName("ACCT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AcctDesc)
                .HasColumnName("ACCT_DESC")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptDesc)
                .HasColumnName("DEPT_DESC")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DpCode)
                .HasColumnName("DP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Flag)
                .HasColumnName("FLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SalesOutlet)
                .HasColumnName("SALES_OUTLET")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Selector)
                .HasColumnName("SELECTOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
