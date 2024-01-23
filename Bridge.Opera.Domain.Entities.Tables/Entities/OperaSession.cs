namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaSession
{
    public decimal InstId { get; set; }
    public decimal Sid { get; set; }
    public decimal? OperaSid { get; set; }
    public string OperaUser { get; set; }
    public string OperaResort { get; set; }
    public decimal? Serial { get; set; }
    public string Jsessionid { get; set; }
    public string Terminal { get; set; }
    public string Appserver { get; set; }
    public DateTime? InsertDate { get; set; }
    public string OsPid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaSession>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OPERA_SESSION");

            entity.HasIndex(e => new { e.InstId, e.Sid, e.OperaSid })
                .HasName("OPERA_SESSION_INDX1");

            entity.Property(e => e.Appserver)
                .HasColumnName("APPSERVER")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Jsessionid)
                .HasColumnName("JSESSIONID")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.OperaResort)
                .HasColumnName("OPERA_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OperaSid)
                .HasColumnName("OPERA_SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaUser)
                .HasColumnName("OPERA_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OsPid)
                .HasColumnName("OS_PID")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.Serial)
                .HasColumnName("SERIAL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(1000)
                .IsUnicode(false);
        });
	}
}
