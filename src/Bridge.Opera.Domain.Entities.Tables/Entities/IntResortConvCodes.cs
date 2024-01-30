namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntResortConvCodes
{
    public decimal? IntCcSeqno { get; set; }
    public string? Resort { get; set; }
    public string? InterfaceId { get; set; }
    public string? ConversionCode { get; set; }
    public string? ActiveYn { get; set; }
    public string? GlobalActiveYn { get; set; }

    public virtual IntInterfaceSetup IntInterfaceSetup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntResortConvCodes>(entity =>
        {
            entity.HasKey(e => e.IntCcSeqno)
                .HasName("INT_IR_PK");

            entity.ToTable("INT_RESORT_CONV_CODES");

            entity.HasIndex(e => e.ConversionCode)
                .HasName("INT_RESORT_CONV_CODES_IND1");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort })
                .HasName("INT_RESOT_CONV_CODES_IND2");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort, e.ConversionCode })
                .HasName("INT_IR_UK")
                .IsUnique();

            entity.Property(e => e.IntCcSeqno)
                .HasColumnName("INT_CC_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConversionCode)
                .IsRequired()
                .HasColumnName("CONVERSION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GlobalActiveYn)
                .HasColumnName("GLOBAL_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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
	                .WithMany(p => p.IntResortConvCodes)
	                .HasForeignKey(d => new { d.InterfaceId, d.Resort })
	                .HasConstraintName("INT_IR_INT_IC_FK");
        });
	}
}
