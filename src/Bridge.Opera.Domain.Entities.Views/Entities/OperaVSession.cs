namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaVSession
{
    public decimal? InstId { get; set; }
    public decimal? Sid { get; set; }
    public decimal? Serialno { get; set; }
    public string? Status { get; set; }
    public string? Module { get; set; }
    public string? ClientInfo { get; set; }
    public string? Terminal { get; set; }
    public string? OperaUser { get; set; }
    public string? ParentAudsid { get; set; }
    public decimal? Audsid { get; set; }
    public string? Action { get; set; }
    public string? Process { get; set; }
    public string? Schemaname { get; set; }
    public string? Machine { get; set; }
    public string? Program { get; set; }
    public string? Osuser { get; set; }
    public decimal? Cursors { get; set; }
    public decimal? Computedusage { get; set; }
    public string? Operauniquesessid { get; set; }
    public string? Username { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaVSession>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_V$SESSION");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Audsid)
                .HasColumnName("AUDSID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClientInfo)
                .HasColumnName("CLIENT_INFO")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Computedusage)
                .HasColumnName("COMPUTEDUSAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cursors)
                .HasColumnName("CURSORS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.OperaUser)
                .HasColumnName("OPERA_USER")
                .IsUnicode(false);

            entity.Property(e => e.Operauniquesessid)
                .HasColumnName("OPERAUNIQUESESSID")
                .IsUnicode(false);

            entity.Property(e => e.Osuser)
                .HasColumnName("OSUSER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ParentAudsid)
                .HasColumnName("PARENT_AUDSID")
                .HasMaxLength(192)
                .IsUnicode(false);

            entity.Property(e => e.Process)
                .HasColumnName("PROCESS")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.Program)
                .HasColumnName("PROGRAM")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Schemaname)
                .HasColumnName("SCHEMANAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Serialno)
                .HasColumnName("SERIALNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .IsUnicode(false);

            entity.Property(e => e.Username)
                .HasColumnName("USERNAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
