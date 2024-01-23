namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidScrPaintFormmodesSys
{
    public string FormName { get; set; }
    public string FormMode { get; set; }
    public string FormId { get; set; }
    public string FormDesc { get; set; }
    public string ModeDesc { get; set; }
    public string Application { get; set; }
    public string DisplayMode { get; set; }
    public byte? SortOrder { get; set; }
    public byte? ModeSortOrder { get; set; }
    public string FormMultiSaveYn { get; set; }
    public string FormView { get; set; }
    public string CheckLicenseYn { get; set; }
    public string FormFieldsQuery { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidScrPaintFormmodesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_SCR_PAINT_FORMMODES_SYS");

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CheckLicenseYn)
                .HasColumnName("CHECK_LICENSE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DisplayMode)
                .HasColumnName("DISPLAY_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormDesc)
                .HasColumnName("FORM_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FormFieldsQuery)
                .HasColumnName("FORM_FIELDS_QUERY")
                .IsUnicode(false);

            entity.Property(e => e.FormId)
                .IsRequired()
                .HasColumnName("FORM_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.FormMode)
                .HasColumnName("FORM_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormMultiSaveYn)
                .HasColumnName("FORM_MULTI_SAVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FormView)
                .HasColumnName("FORM_VIEW")
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.Property(e => e.ModeDesc)
                .HasColumnName("MODE_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ModeSortOrder)
                .HasColumnName("MODE_SORT_ORDER")
                .HasColumnType("NUMBER(4)");

            entity.Property(e => e.SortOrder)
                .HasColumnName("SORT_ORDER")
                .HasColumnType("NUMBER(4)");
        });
	}
}
