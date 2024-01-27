namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaLocks
{
    public decimal InstId { get; set; }
    public decimal Audsid { get; set; }
    public decimal? Sid { get; set; }
    public decimal? Serial { get; set; }
    public string TableName { get; set; }
    public string KeyValue1 { get; set; }
    public string KeyValue2 { get; set; }
    public string KeyValue3 { get; set; }
    public string KeyValue4 { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? LockId { get; set; }
    public string LockMode { get; set; }
    public string StatelessYn { get; set; }
    public decimal? UserId { get; set; }
    public decimal? TimeToKeepLock { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaLocks>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OPERA_LOCKS");

            entity.HasIndex(e => e.LockId)
                .HasName("OPERA_LOCKS_IDX3");

            entity.HasIndex(e => new { e.InstId, e.Audsid })
                .HasName("OPERA_LOCKS_IDX1");

            entity.HasIndex(e => new { e.TableName, e.KeyValue1, e.KeyValue2, e.LockMode })
                .HasName("OPERA_LOCKS_IDX2");

            entity.Property(e => e.Audsid)
                .HasColumnName("AUDSID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyValue1)
                .IsRequired()
                .HasColumnName("KEY_VALUE1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.KeyValue2)
                .HasColumnName("KEY_VALUE2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.KeyValue3)
                .HasColumnName("KEY_VALUE3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.KeyValue4)
                .HasColumnName("KEY_VALUE4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LockId)
                .HasColumnName("LOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LockMode)
                .HasColumnName("LOCK_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Serial)
                .HasColumnName("SERIAL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatelessYn)
                .HasColumnName("STATELESS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TimeToKeepLock)
                .HasColumnName("TIME_TO_KEEP_LOCK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");
        });
	}
}
