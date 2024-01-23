namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NaReportParameters
{
    public decimal RequestId { get; set; }
    public string ParameterName { get; set; }
    public string ParameterValue { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

    public virtual NaFinreportStatus Request { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NaReportParameters>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NA_REPORT_PARAMETERS");

            entity.HasIndex(e => e.RequestId)
                .HasName("NA_REP_PARAM_REQID_IDX");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(NaFinreportStatus)))
				entity.Ignore(e => e.Request);
			else
	            entity.HasOne(d => d.Request)
	                .WithMany()
	                .HasForeignKey(d => d.RequestId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("NARP_NA_FINREP_STATUS_FK");
        });
	}
}
