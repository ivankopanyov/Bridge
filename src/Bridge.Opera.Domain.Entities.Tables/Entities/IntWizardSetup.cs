namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntWizardSetup
{
    public decimal? WizSetupId { get; set; }
    public decimal? WizconfigId { get; set; }
    public string? Properties { get; set; }
    public string? Disabled { get; set; }
    public string? MandatRecom { get; set; }
    public string? Remarks { get; set; }
    public string? Auditlog { get; set; }

    public virtual IntWizardConfig Wizconfig { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntWizardSetup>(entity =>
        {
            entity.HasKey(e => e.WizSetupId)
                .HasName("SYS_C0030045");

            entity.ToTable("INT_WIZARD_SETUP");

            entity.HasIndex(e => e.WizconfigId)
                .HasName("INT_WIZARD_SETUP_FKI");

            entity.Property(e => e.WizSetupId)
                .HasColumnName("WIZ_SETUP_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.Auditlog)
                .HasColumnName("AUDITLOG")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Disabled)
                .IsRequired()
                .HasColumnName("DISABLED")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.MandatRecom)
                .HasColumnName("MANDAT_RECOM")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Properties)
                .HasColumnName("PROPERTIES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .IsUnicode(false);

            entity.Property(e => e.WizconfigId)
                .HasColumnName("WIZCONFIG_ID")
                .HasColumnType("NUMBER(38)");

			if (!types.Contains(typeof(IntWizardConfig)))
				entity.Ignore(e => e.Wizconfig);
			else
	            entity.HasOne(d => d.Wizconfig)
	                .WithMany(p => p.IntWizardSetup)
	                .HasForeignKey(d => d.WizconfigId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("INT_WIZARD_SETUP_FK");
        });
	}
}
