namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GvSessionView
{
    public decimal? InstId { get; set; }
    public byte[] Saddr { get; set; }
    public decimal? Sid { get; set; }
    public decimal? Serial { get; set; }
    public decimal? Audsid { get; set; }
    public byte[] Paddr { get; set; }
    public decimal? User { get; set; }
    public string Username { get; set; }
    public decimal? Command { get; set; }
    public decimal? Ownerid { get; set; }
    public string Taddr { get; set; }
    public string Lockwait { get; set; }
    public string Status { get; set; }
    public string Server { get; set; }
    public decimal? Schema { get; set; }
    public string Schemaname { get; set; }
    public string Osuser { get; set; }
    public string Process { get; set; }
    public string Machine { get; set; }
    public string Terminal { get; set; }
    public string Program { get; set; }
    public string Type { get; set; }
    public byte[] SqlAddress { get; set; }
    public decimal? SqlHashValue { get; set; }
    public byte[] PrevSqlAddr { get; set; }
    public decimal? PrevHashValue { get; set; }
    public string Module { get; set; }
    public decimal? ModuleHash { get; set; }
    public string Action { get; set; }
    public decimal? ActionHash { get; set; }
    public string ClientInfo { get; set; }
    public decimal? FixedTableSequence { get; set; }
    public decimal? RowWaitObj { get; set; }
    public decimal? RowWaitFile { get; set; }
    public decimal? RowWaitBlock { get; set; }
    public decimal? RowWaitRow { get; set; }
    public DateTime? LogonTime { get; set; }
    public decimal? LastCallEt { get; set; }
    public string PdmlEnabled { get; set; }
    public string FailoverType { get; set; }
    public string FailoverMethod { get; set; }
    public string FailedOver { get; set; }
    public string ResourceConsumerGroup { get; set; }
    public string PdmlStatus { get; set; }
    public string PddlStatus { get; set; }
    public string PqStatus { get; set; }
    public decimal? CurrentQueueDuration { get; set; }
    public string ClientIdentifier { get; set; }
    public string OperaUser { get; set; }
    public string OperaTerminal { get; set; }
    public string ParentAudsid { get; set; }
    public string Operauniquesessid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GvSessionView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GV_SESSION_VIEW");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ActionHash)
                .HasColumnName("ACTION_HASH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Audsid)
                .HasColumnName("AUDSID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClientIdentifier)
                .HasColumnName("CLIENT_IDENTIFIER")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ClientInfo)
                .HasColumnName("CLIENT_INFO")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Command)
                .HasColumnName("COMMAND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentQueueDuration)
                .HasColumnName("CURRENT_QUEUE_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FailedOver)
                .HasColumnName("FAILED_OVER")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.FailoverMethod)
                .HasColumnName("FAILOVER_METHOD")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.FailoverType)
                .HasColumnName("FAILOVER_TYPE")
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.Property(e => e.FixedTableSequence)
                .HasColumnName("FIXED_TABLE_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastCallEt)
                .HasColumnName("LAST_CALL_ET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Lockwait)
                .HasColumnName("LOCKWAIT")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.LogonTime)
                .HasColumnName("LOGON_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ModuleHash)
                .HasColumnName("MODULE_HASH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaTerminal)
                .HasColumnName("OPERA_TERMINAL")
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

            entity.Property(e => e.Ownerid)
                .HasColumnName("OWNERID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Paddr)
                .HasColumnName("PADDR")
                .HasMaxLength(8);

            entity.Property(e => e.ParentAudsid)
                .HasColumnName("PARENT_AUDSID")
                .HasMaxLength(192)
                .IsUnicode(false);

            entity.Property(e => e.PddlStatus)
                .HasColumnName("PDDL_STATUS")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.PdmlEnabled)
                .HasColumnName("PDML_ENABLED")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PdmlStatus)
                .HasColumnName("PDML_STATUS")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.PqStatus)
                .HasColumnName("PQ_STATUS")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.PrevHashValue)
                .HasColumnName("PREV_HASH_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrevSqlAddr)
                .HasColumnName("PREV_SQL_ADDR")
                .HasMaxLength(8);

            entity.Property(e => e.Process)
                .HasColumnName("PROCESS")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.Program)
                .HasColumnName("PROGRAM")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ResourceConsumerGroup)
                .HasColumnName("RESOURCE_CONSUMER_GROUP")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.RowWaitBlock)
                .HasColumnName("ROW_WAIT_BLOCK#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowWaitFile)
                .HasColumnName("ROW_WAIT_FILE#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowWaitObj)
                .HasColumnName("ROW_WAIT_OBJ#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowWaitRow)
                .HasColumnName("ROW_WAIT_ROW#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Saddr)
                .HasColumnName("SADDR")
                .HasMaxLength(8);

            entity.Property(e => e.Schema)
                .HasColumnName("SCHEMA#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Schemaname)
                .HasColumnName("SCHEMANAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Serial)
                .HasColumnName("SERIAL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Server)
                .HasColumnName("SERVER")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SqlAddress)
                .HasColumnName("SQL_ADDRESS")
                .HasMaxLength(8);

            entity.Property(e => e.SqlHashValue)
                .HasColumnName("SQL_HASH_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Taddr)
                .HasColumnName("TADDR")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.User)
                .HasColumnName("USER#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Username)
                .HasColumnName("USERNAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
