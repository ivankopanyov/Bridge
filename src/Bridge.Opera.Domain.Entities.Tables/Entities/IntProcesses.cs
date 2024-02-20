namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntProcesses
{
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? ProcessType { get; set; }
    public string? Description { get; set; }
    public decimal? Sid { get; set; }
    public decimal? SerialNo { get; set; }
    public string? Machine { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? StopTime { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? ProcessName { get; set; }
    public string? DisplayYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntProcesses>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_PROCESSES");

            entity.HasIndex(e => new { e.Resort, e.ProcessType, e.InterfaceId })
                .HasName("INT_IP_UK")
                .IsUnique();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .IsRequired()
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("SYSDATE ");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("UID ");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ProcessName)
                .HasColumnName("PROCESS_NAME")
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.Property(e => e.ProcessType)
                .IsRequired()
                .HasColumnName("PROCESS_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SerialNo)
                .HasColumnName("SERIAL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.StopTime)
                .HasColumnName("STOP_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
