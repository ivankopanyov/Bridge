namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PaymentTaxTypes
{
    public string PaymentType { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PaymentTaxTypes>(entity =>
        {
            entity.HasKey(e => e.PaymentType)
                .HasName("PTT_PK");

            entity.ToTable("PAYMENT_TAX_TYPES");

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
