namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntJobParameters
{
    public decimal Jobseqno { get; set; }
    public decimal? Jobid { get; set; }
    public string Procedurename { get; set; }
    public string Interfaceid { get; set; }
    public string Pmsresort { get; set; }
    public string Crsresort { get; set; }
    public string Status { get; set; }
    public string Terminal { get; set; }
    public string Schemaname { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntJobParameters>(entity =>
        {
            entity.HasKey(e => e.Jobseqno)
                .HasName("INT_JOB_PARAMETERS_PK");

            entity.ToTable("INT_JOB_PARAMETERS");

            entity.Property(e => e.Jobseqno)
                .HasColumnName("JOBSEQNO")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.Crsresort)
                .HasColumnName("CRSRESORT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Interfaceid)
                .HasColumnName("INTERFACEID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Jobid)
                .HasColumnName("JOBID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.Pmsresort)
                .HasColumnName("PMSRESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Procedurename)
                .HasColumnName("PROCEDURENAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Schemaname)
                .HasColumnName("SCHEMANAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
