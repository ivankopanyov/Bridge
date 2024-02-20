namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsAction
{
    public decimal? ActionId { get; set; }
    public string? ActionType { get; set; }
    public string? ActionDescription { get; set; }
    public string? ModuleType { get; set; }
    public string? ModuleTypeKeyValue { get; set; }
    public string? GdsHost { get; set; }
    public string? Resort { get; set; }
    public string? Terminal { get; set; }
    public string? Machine { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAction>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("GDS_ACTION_PK");

            entity.ToTable("GDS_ACTION");

            entity.HasIndex(e => new { e.InsertDate, e.Resort })
                .HasName("GDS_ACTION_IND2");

            entity.HasIndex(e => new { e.ModuleType, e.GdsHost, e.Resort, e.ModuleTypeKeyValue })
                .HasName("GDS_ACTION_IND1");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
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
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ModuleTypeKeyValue)
                .HasColumnName("MODULE_TYPE_KEY_VALUE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
