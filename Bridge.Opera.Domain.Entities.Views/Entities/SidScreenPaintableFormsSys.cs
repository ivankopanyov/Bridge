namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidScreenPaintableFormsSys
{
    public string FormName { get; set; }
    public string Application { get; set; }
    public string Description { get; set; }
    public string ManualSp { get; set; }
    public string DesignMode { get; set; }
    public string DynamicConditions { get; set; }
    public string Udfs { get; set; }
    public string Comments { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidScreenPaintableFormsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_SCREEN_PAINTABLE_FORMS_SYS");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("APPLICATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DesignMode)
                .HasColumnName("DESIGN_MODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DynamicConditions)
                .HasColumnName("DYNAMIC_CONDITIONS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ManualSp)
                .HasColumnName("MANUAL_SP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Udfs)
                .HasColumnName("UDFS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
