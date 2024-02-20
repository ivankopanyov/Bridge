namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntCcDefaults
{
    public decimal? IntCcDefSeqno { get; set; }
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? ConversionCode { get; set; }
    public string? DefaultPmsValue { get; set; }
    public string? DefaultExtValue { get; set; }
    public string? GlobalActiveYn { get; set; }

    public virtual IntInterfaceSetup IntInterfaceSetup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntCcDefaults>(entity =>
        {
            entity.HasKey(e => e.IntCcDefSeqno)
                .HasName("INT_DEF_PK");

            entity.ToTable("INT_CC_DEFAULTS");

            entity.HasIndex(e => e.ConversionCode)
                .HasName("INT_CC_DETAILS_IND1");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort, e.ConversionCode })
                .HasName("INT_DEF_UK")
                .IsUnique();

            entity.Property(e => e.IntCcDefSeqno)
                .HasColumnName("INT_CC_DEF_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConversionCode)
                .IsRequired()
                .HasColumnName("CONVERSION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultExtValue)
                .HasColumnName("DEFAULT_EXT_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultPmsValue)
                .HasColumnName("DEFAULT_PMS_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GlobalActiveYn)
                .HasColumnName("GLOBAL_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(IntInterfaceSetup)))
				entity.Ignore(e => e.IntInterfaceSetup);
			else
	            entity.HasOne(d => d.IntInterfaceSetup)
	                .WithMany(p => p.IntCcDefaults)
	                .HasForeignKey(d => new { d.InterfaceId, d.Resort })
	                .HasConstraintName("INT_DEF_INT_IC_FK");
        });
	}
}
