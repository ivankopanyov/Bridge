namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InterfaceDebug
{
    public decimal? ProcessSeq { get; set; }
    public string ProcessType { get; set; }
    public string ProcessName { get; set; }
    public string TableName { get; set; }
    public string Resort { get; set; }
    public string Crskeyvalue { get; set; }
    public string Pmskeyvalue { get; set; }
    public DateTime? ProcessDate { get; set; }
    public string ProcessDesc { get; set; }
    public decimal? ProcessTime { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InterfaceDebug>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INTERFACE_DEBUG");

            entity.Property(e => e.Crskeyvalue)
                .HasColumnName("CRSKEYVALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Pmskeyvalue)
                .HasColumnName("PMSKEYVALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProcessDate)
                .HasColumnName("PROCESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProcessDesc)
                .HasColumnName("PROCESS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ProcessName)
                .HasColumnName("PROCESS_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ProcessSeq)
                .HasColumnName("PROCESS_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessTime)
                .HasColumnName("PROCESS_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessType)
                .HasColumnName("PROCESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
