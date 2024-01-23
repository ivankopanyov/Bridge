namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArTraces
{
    public string Status { get; set; }
    public string Resort { get; set; }
    public decimal AccountCode { get; set; }
    public DateTime TraceDate { get; set; }
    public string Trace { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? ResolvedDate { get; set; }

    public virtual ArAccount ArAccount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArTraces>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AR$_TRACES");

            entity.HasIndex(e => new { e.Resort, e.AccountCode })
                .HasName("AR_TRACE_NDX");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResolvedDate)
                .HasColumnName("RESOLVED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Trace)
                .IsRequired()
                .HasColumnName("TRACE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TraceDate)
                .HasColumnName("TRACE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ArAccount)))
				entity.Ignore(e => e.ArAccount);
			else
	            entity.HasOne(d => d.ArAccount)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.AccountCode })
	                .HasConstraintName("AR$_ACCOUNT");
        });
	}
}
