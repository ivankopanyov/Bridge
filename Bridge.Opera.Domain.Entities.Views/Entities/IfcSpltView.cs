namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcSpltView
{
    public string Resort { get; set; }
    public string SplitCode { get; set; }
    public string SplitFld { get; set; }
    public decimal? SplitPost { get; set; }
    public decimal? SplitFact { get; set; }
    public string SplitText { get; set; }
    public string DbfLogo { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcSpltView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_SPLT_VIEW");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SplitCode)
                .HasColumnName("SPLIT_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.SplitFact)
                .HasColumnName("SPLIT_FACT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SplitFld)
                .HasColumnName("SPLIT_FLD")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.SplitPost)
                .HasColumnName("SPLIT_POST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SplitText)
                .HasColumnName("SPLIT_TEXT")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
