namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntWizardConfigVw
{
    public decimal? WizConfigId { get; set; }
    public string? ApplicationId { get; set; }
    public string? InterfaceId { get; set; }
    public string? Category { get; set; }
    public string? Item { get; set; }
    public string? SubItem { get; set; }
    public string? Value { get; set; }
    public string? MandatRecom { get; set; }
    public string? ScriptFile { get; set; }
    public string? Description { get; set; }
    public decimal? WizOutputId { get; set; }
    public decimal? WizconfigId1 { get; set; }
    public string? ValueSet { get; set; }
    public string? Target { get; set; }
    public string? Fixable { get; set; }
    public string? Fixed { get; set; }
    public string? Interface { get; set; }
    public string? Property { get; set; }
    public string? Remarks { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntWizardConfigVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_WIZARD_CONFIG_VW");

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

            entity.Property(e => e.Fixable)
                .HasColumnName("FIXABLE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Fixed)
                .HasColumnName("FIXED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Interface)
                .HasColumnName("INTERFACE")
                .HasMaxLength(100)
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
                .IsUnicode(false);

            entity.Property(e => e.Property)
                .HasColumnName("PROPERTY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .IsUnicode(false);

            entity.Property(e => e.ScriptFile)
                .HasColumnName("SCRIPT_FILE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SubItem)
                .HasColumnName("SUB_ITEM")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Target)
                .HasColumnName("TARGET")
                .HasColumnType("UROWID");

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ValueSet)
                .HasColumnName("VALUE_SET")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.WizConfigId)
                .HasColumnName("WIZ_CONFIG_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.WizOutputId)
                .HasColumnName("WIZ_OUTPUT_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.WizconfigId1)
                .HasColumnName("WIZCONFIG_ID")
                .HasColumnType("NUMBER(38)");
        });
	}
}
