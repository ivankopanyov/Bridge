namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidIntWizardConfigSys
{
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

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidIntWizardConfigSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INT_WIZARD_CONFIG_SYS");

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
                .IsUnicode(false);

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

            entity.Property(e => e.WizConfigId)
                .HasColumnName("WIZ_CONFIG_ID")
                .HasColumnType("NUMBER(38)");
        });
	}
}
