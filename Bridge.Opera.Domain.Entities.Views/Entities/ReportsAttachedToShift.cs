namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReportsAttachedToShift
{
    public decimal ShiftGroupId { get; set; }
    public decimal ModuleId { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDesc { get; set; }
    public string ReportGroup { get; set; }
    public string UserDefinedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReportsAttachedToShift>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REPORTS_ATTACHED_TO_SHIFT");

            entity.Property(e => e.ModuleDesc)
                .HasColumnName("MODULE_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReportGroup)
                .HasColumnName("REPORT_GROUP")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ShiftGroupId)
                .HasColumnName("SHIFT_GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserDefinedYn)
                .HasColumnName("USER_DEFINED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
