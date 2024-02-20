namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Traces
{
    public decimal? Sid { get; set; }
    public decimal? Serial { get; set; }
    public decimal? Cpuio { get; set; }
    public string? Status { get; set; }
    public string? Schema { get; set; }
    public string? Terminal { get; set; }
    public string? OperaModule { get; set; }
    public string? OperaUser { get; set; }
    public DateTime? LogonTime { get; set; }
    public string? Application { get; set; }
    public string? Comments { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? TraceFile { get; set; }
    public decimal? Parentaudsid { get; set; }
    public decimal? Audsid { get; set; }
    public decimal? InstanceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Traces>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TRACES");

            entity.HasIndex(e => e.Parentaudsid)
                .HasName("TRACES_AUDSID_IDX");

            entity.HasIndex(e => new { e.Sid, e.Serial })
                .HasName("TRACES_IND");

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Audsid)
                .HasColumnName("AUDSID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Cpuio)
                .HasColumnName("CPUIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InstanceId)
                .HasColumnName("INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LogonTime)
                .HasColumnName("LOGON_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.OperaModule)
                .HasColumnName("OPERA_MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OperaUser)
                .HasColumnName("OPERA_USER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Parentaudsid)
                .HasColumnName("PARENTAUDSID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Schema)
                .HasColumnName("SCHEMA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Serial)
                .HasColumnName("SERIAL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TraceFile)
                .HasColumnName("TRACE_FILE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
