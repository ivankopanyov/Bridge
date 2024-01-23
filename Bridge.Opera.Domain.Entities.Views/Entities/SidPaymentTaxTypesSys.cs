namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidPaymentTaxTypesSys
{
    public string PaymentType { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidPaymentTaxTypesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_PAYMENT_TAX_TYPES_SYS");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PaymentType)
                .IsRequired()
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);
        });
	}
}
