namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExternalReportRequestParams
{
    public decimal? OperaRequestId { get; set; }
    public string? ParameterName { get; set; }
    public string? ParameterValue { get; set; }

    public virtual ExternalReportRequests OperaRequest { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExternalReportRequestParams>(entity =>
        {
            entity.HasKey(e => new { e.OperaRequestId, e.ParameterName })
                .HasName("EXTERNAL_REPORT_REQ_PARAMS_PK");

            entity.ToTable("EXTERNAL_REPORT_REQUEST_PARAMS");

            entity.Property(e => e.OperaRequestId)
                .HasColumnName("OPERA_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(ExternalReportRequests)))
				entity.Ignore(e => e.OperaRequest);
			else
	            entity.HasOne(d => d.OperaRequest)
	                .WithMany(p => p.ExternalReportRequestParams)
	                .HasForeignKey(d => d.OperaRequestId)
	                .HasConstraintName("ERRP_ERR_FK");
        });
	}
}
