namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidIntWizardRegsSys
{
    public decimal WizardRegsId { get; set; }
    public string ApplicationId { get; set; }
    public string InterfaceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidIntWizardRegsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INT_WIZARD_REGS_SYS");

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

            entity.Property(e => e.WizardRegsId)
                .HasColumnName("WIZARD_REGS_ID")
                .HasColumnType("NUMBER(38)");
        });
	}
}
