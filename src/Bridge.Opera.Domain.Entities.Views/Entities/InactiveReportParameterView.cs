namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveReportParameterView
{
    public string? ReportParameterName { get; set; }
    public string? ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveReportParameterView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_REPORT_PARAMETER_VIEW");

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReportParameterName)
                .IsRequired()
                .HasColumnName("REPORT_PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
