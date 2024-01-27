namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcDcView
{
    public string Resort { get; set; }
    public string DcType { get; set; }
    public string Sp { get; set; }
    public string Rc { get; set; }
    public string Tr { get; set; }
    public string Pn { get; set; }
    public string Ui { get; set; }
    public string Pr { get; set; }
    public string Lt { get; set; }
    public string Dd { get; set; }
    public string ItemNum { get; set; }
    public string DpCode { get; set; }
    public string Text { get; set; }
    public string DbfLogo { get; set; }
    public decimal? RowNum { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcDcView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_DC_VIEW");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.DcType)
                .HasColumnName("DC_TYPE")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Dd)
                .HasColumnName("DD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DpCode)
                .HasColumnName("DP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemNum)
                .HasColumnName("ITEM_NUM")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Lt)
                .HasColumnName("LT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Pn)
                .HasColumnName("PN")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Pr)
                .HasColumnName("PR")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Rc)
                .HasColumnName("RC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowNum)
                .HasColumnName("ROW_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sp)
                .HasColumnName("SP")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tr)
                .HasColumnName("TR")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Ui)
                .HasColumnName("UI")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
