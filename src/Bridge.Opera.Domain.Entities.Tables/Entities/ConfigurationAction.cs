namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ConfigurationAction
{
    public decimal? ActionInstanceId { get; set; }
    public string? ActionType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? Terminal { get; set; }
    public string? Machine { get; set; }
    public string? ActionDescription { get; set; }
    public string? ModuleType { get; set; }
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? ChainCode { get; set; }
    public decimal? PermissionAppUserId { get; set; }
    public decimal? ParentActionInstanceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConfigurationAction>(entity =>
        {
            entity.HasKey(e => e.ActionInstanceId)
                .HasName("CONFIGURATION_ACTION_PK");

            entity.ToTable("CONFIGURATION_ACTION");

            entity.HasIndex(e => new { e.ActionType, e.Resort })
                .HasName("CONF_ACTION_TYPE_IDX");

            entity.HasIndex(e => new { e.InsertDate, e.ChainCode })
                .HasName("CONF_INSERT_DATE_IDX");

            entity.HasIndex(e => new { e.ParentActionInstanceId, e.ActionInstanceId })
                .HasName("CONF_ACTION_PARENT_IDX");

            entity.HasIndex(e => new { e.RateCode, e.Resort })
                .HasName("CONFIGURATION_ACTION_IND2");

            entity.HasIndex(e => new { e.ModuleType, e.InsertDate, e.Resort, e.ChainCode })
                .HasName("CONFIGURATION_ACTION_IND1");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParentActionInstanceId)
                .HasColumnName("PARENT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermissionAppUserId)
                .HasColumnName("PERMISSION_APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
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
