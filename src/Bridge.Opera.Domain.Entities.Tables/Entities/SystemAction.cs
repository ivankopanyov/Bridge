namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SystemAction
{
    public decimal? ActionInstanceId { get; set; }
    public string? ActionType { get; set; }
    public string? ActionDescription { get; set; }
    public string? ModuleType { get; set; }
    public string? Terminal { get; set; }
    public string? Machine { get; set; }
    public string? Resort { get; set; }
    public string? ChainCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? ActionDescriptionFull { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SystemAction>(entity =>
        {
            entity.HasKey(e => e.ActionInstanceId)
                .HasName("SYSTEM_ACTION_PK");

            entity.ToTable("SYSTEM_ACTION");

            entity.HasIndex(e => new { e.InsertDate, e.ChainCode })
                .HasName("SYS_ACTION_INSERT_DATE_IDX");

            entity.HasIndex(e => new { e.ActionType, e.InsertDate, e.ChainCode })
                .HasName("SYS_ACTION_TYPE_IDX");

            entity.HasIndex(e => new { e.ModuleType, e.InsertDate, e.ChainCode })
                .HasName("SYS_ACTION_MODULE_TYPE_IDX");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.ActionDescriptionFull)
                .HasColumnName("ACTION_DESCRIPTION_FULL")
                .HasColumnType("CLOB");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ModuleType)
                .IsRequired()
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
