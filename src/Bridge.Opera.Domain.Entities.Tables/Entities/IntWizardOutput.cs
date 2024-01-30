namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntWizardOutput
{
    public decimal? WizOutputId { get; set; }
    public decimal? WizconfigId { get; set; }
    public string? ValueSet { get; set; }
    public string? Target { get; set; }
    public string? Fixable { get; set; }
    public string? Fixed { get; set; }
    public string? Interface { get; set; }
    public string? Property { get; set; }
    public string? Remarks { get; set; }

    public virtual IntWizardConfig Wizconfig { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntWizardOutput>(entity =>
        {
            entity.HasKey(e => e.WizOutputId)
                .HasName("SYS_C0030036");

            entity.ToTable("INT_WIZARD_OUTPUT");

            entity.HasIndex(e => e.WizconfigId)
                .HasName("INT_WIZARD_OUTPUT_FKI");

            entity.Property(e => e.WizOutputId)
                .HasColumnName("WIZ_OUTPUT_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.Fixable)
                .IsRequired()
                .HasColumnName("FIXABLE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.Fixed)
                .IsRequired()
                .HasColumnName("FIXED")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.Interface)
                .HasColumnName("INTERFACE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Property)
                .HasColumnName("PROPERTY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .IsUnicode(false);

            entity.Property(e => e.Target)
                .HasColumnName("TARGET")
                .HasColumnType("UROWID");

            entity.Property(e => e.ValueSet)
                .HasColumnName("VALUE_SET")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.WizconfigId)
                .HasColumnName("WIZCONFIG_ID")
                .HasColumnType("NUMBER(38)");

			if (!types.Contains(typeof(IntWizardConfig)))
				entity.Ignore(e => e.Wizconfig);
			else
	            entity.HasOne(d => d.Wizconfig)
	                .WithMany(p => p.IntWizardOutput)
	                .HasForeignKey(d => d.WizconfigId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("INT_WIZARD_OUTPUT_FK");
        });
	}
}
