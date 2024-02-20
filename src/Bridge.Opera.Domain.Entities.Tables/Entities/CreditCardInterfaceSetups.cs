namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CreditCardInterfaceSetups
{
    public decimal? CCReaderDeviceId { get; set; }
    public string? Resort { get; set; }
    public decimal? CCInterfaceSetupId { get; set; }

    public virtual CreditCardIntfaceGnrlPar ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CreditCardInterfaceSetups>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CCReaderDeviceId, e.CCInterfaceSetupId })
                .HasName("CCIS_PK");

            entity.ToTable("CREDIT_CARD_INTERFACE_SETUPS");

            entity.HasIndex(e => e.CCReaderDeviceId)
                .HasName("CCIS_CCRD_FK_I");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.CCReaderDeviceId)
                .HasColumnName("C_C_READER_DEVICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CCInterfaceSetupId)
                .HasColumnName("C_C_INTERFACE_SETUP_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(CreditCardIntfaceGnrlPar)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.CreditCardInterfaceSetups)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CCIS_CCIGP_FK");
        });
	}
}
