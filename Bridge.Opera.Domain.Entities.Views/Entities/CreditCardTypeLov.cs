namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CreditCardTypeLov
{
    public string Resort { get; set; }
    public string CardType { get; set; }
    public string Description { get; set; }
    public string CcTypeIfc { get; set; }
    public string CreditCardRowid { get; set; }
    public string CcType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CreditCardTypeLov>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CREDIT_CARD_TYPE_LOV");

            entity.Property(e => e.CardType)
                .IsRequired()
                .HasColumnName("CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CcTypeIfc)
                .HasColumnName("CC_TYPE_IFC")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardRowid)
                .HasColumnName("CREDIT_CARD_ROWID")
                .HasColumnType("ROWID");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
