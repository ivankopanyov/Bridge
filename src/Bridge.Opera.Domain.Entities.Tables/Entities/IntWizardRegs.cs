namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntWizardRegs
{
    public decimal WizardRegsId { get; set; }
    public string ApplicationId { get; set; }
    public string InterfaceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntWizardRegs>(entity =>
        {
            entity.HasKey(e => e.WizardRegsId)
                .HasName("SYS_C0030039");

            entity.ToTable("INT_WIZARD_REGS");

            entity.HasIndex(e => new { e.ApplicationId, e.InterfaceId })
                .HasName("INT_WIZARD_REGS_UK")
                .IsUnique();

            entity.Property(e => e.WizardRegsId)
                .HasColumnName("WIZARD_REGS_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.ApplicationId)
                .IsRequired()
                .HasColumnName("APPLICATION_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
