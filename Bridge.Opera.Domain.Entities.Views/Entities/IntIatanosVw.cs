namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntIatanosVw
{
    public string Nrowid { get; set; }
    public decimal NameId { get; set; }
    public string Iatano { get; set; }
    public string Status { get; set; }
    public string Name { get; set; }
    public string Bankaccountno { get; set; }
    public string PaymentMethod { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntIatanosVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_IATANOS_VW");

            entity.Property(e => e.Bankaccountno)
                .HasColumnName("BANKACCOUNTNO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Iatano)
                .HasColumnName("IATANO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nrowid)
                .HasColumnName("NROWID")
                .HasColumnType("ROWID");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(7)
                .IsUnicode(false);
        });
	}
}
