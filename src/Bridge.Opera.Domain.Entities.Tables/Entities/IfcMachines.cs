namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcMachines
{
    public decimal? Id { get; set; }
    public string? Machine { get; set; }
    public string? Program { get; set; }
    public decimal? ControllerPort { get; set; }
    public string? ConfigFile { get; set; }
    public decimal? VncPort { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? Status { get; set; }
    public string? StatusMsg { get; set; }
    public string? Ctrlver { get; set; }
    public string? Dbrstconninterval { get; set; }
    public string? Dbrstconntime { get; set; }
    public string? Loglevel { get; set; }
    public string? Logmax { get; set; }
    public string? Logpath { get; set; }
    public string? Logpurge { get; set; }
    public string? Operadb { get; set; }
    public string? Operaifcws { get; set; }
    public string? RbRowid { get; set; }
    public string? SendcfgxmlYn { get; set; }
    public string? Sendinterval { get; set; }
    public string? UseclobYn { get; set; }
    public string? Wsmaxretry { get; set; }
    public string? Wsretryinterval { get; set; }
    public string? Wstimeout { get; set; }
    public string? Rbinterval { get; set; }
    public string? ControllerStarttime { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcMachines>(entity =>
        {
            entity.ToTable("IFC_MACHINES");

            entity.HasIndex(e => e.Machine)
                .HasName("IFCM_UK")
                .IsUnique();

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfigFile)
                .HasColumnName("CONFIG_FILE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ControllerPort)
                .HasColumnName("CONTROLLER_PORT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ControllerStarttime)
                .HasColumnName("CONTROLLER_STARTTIME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Ctrlver)
                .HasColumnName("CTRLVER")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Dbrstconninterval)
                .HasColumnName("DBRSTCONNINTERVAL")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Dbrstconntime)
                .HasColumnName("DBRSTCONNTIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Loglevel)
                .HasColumnName("LOGLEVEL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Logmax)
                .HasColumnName("LOGMAX")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Logpath)
                .HasColumnName("LOGPATH")
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Logpurge)
                .HasColumnName("LOGPURGE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Machine)
                .IsRequired()
                .HasColumnName("MACHINE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Operadb)
                .HasColumnName("OPERADB")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Operaifcws)
                .HasColumnName("OPERAIFCWS")
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Program)
                .IsRequired()
                .HasColumnName("PROGRAM")
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.RbRowid)
                .HasColumnName("RB_ROWID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Rbinterval)
                .HasColumnName("RBINTERVAL")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.SendcfgxmlYn)
                .HasColumnName("SENDCFGXML_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Sendinterval)
                .HasColumnName("SENDINTERVAL")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.StatusMsg)
                .HasColumnName("STATUS_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UseclobYn)
                .HasColumnName("USECLOB_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VncPort)
                .HasColumnName("VNC_PORT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Wsmaxretry)
                .HasColumnName("WSMAXRETRY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Wsretryinterval)
                .HasColumnName("WSRETRYINTERVAL")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Wstimeout)
                .HasColumnName("WSTIMEOUT")
                .HasMaxLength(5)
                .IsUnicode(false);
        });
	}
}
