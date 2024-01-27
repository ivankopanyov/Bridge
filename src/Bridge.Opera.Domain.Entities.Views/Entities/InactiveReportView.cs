namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveReportView
{
    public string ReportName { get; set; }
    public string ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveReportView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_REPORT_VIEW");

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReportName)
                .IsRequired()
                .HasColumnName("REPORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
