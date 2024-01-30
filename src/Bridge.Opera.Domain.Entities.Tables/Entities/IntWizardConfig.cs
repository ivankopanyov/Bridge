namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntWizardConfig
{
    public IntWizardConfig()
    {
        IntWizardOutput = new HashSet<IntWizardOutput>();
        IntWizardSetup = new HashSet<IntWizardSetup>();
    }

    public decimal? WizConfigId { get; set; }
    public string? ApplicationId { get; set; }
    public string? InterfaceId { get; set; }
    public string? Category { get; set; }
    public string? Item { get; set; }
    public string? Value { get; set; }
    public string? MandatRecom { get; set; }
    public string? ScriptFile { get; set; }
    public string? Description { get; set; }
    public string? SubItem { get; set; }

    public virtual ICollection<IntWizardOutput> IntWizardOutput { get; set; }
    public virtual ICollection<IntWizardSetup> IntWizardSetup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntWizardConfig>(entity =>
        {
            entity.HasKey(e => e.WizConfigId)
                .HasName("SYS_C0030029");

            entity.ToTable("INT_WIZARD_CONFIG");

            entity.HasIndex(e => new { e.InterfaceId, e.Category, e.Item, e.SubItem })
                .HasName("INT_WIZARD_CONFIG_UK")
                .IsUnique();

            entity.Property(e => e.WizConfigId)
                .HasColumnName("WIZ_CONFIG_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.ApplicationId)
                .IsRequired()
                .HasColumnName("APPLICATION_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Category)
                .IsRequired()
                .HasColumnName("CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Item)
                .IsRequired()
                .HasColumnName("ITEM")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.MandatRecom)
                .IsRequired()
                .HasColumnName("MANDAT_RECOM")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'R'");

            entity.Property(e => e.ScriptFile)
                .HasColumnName("SCRIPT_FILE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SubItem)
                .HasColumnName("SUB_ITEM")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .HasMaxLength(1000)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(IntWizardOutput)))
				entity.Ignore(e => e.IntWizardOutput);

			if (!types.Contains(typeof(IntWizardSetup)))
				entity.Ignore(e => e.IntWizardSetup);
		});
	}
}
