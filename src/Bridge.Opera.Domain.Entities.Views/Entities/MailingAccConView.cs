namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MailingAccConView
{
    public decimal BookingId { get; set; }
    public string LinkType { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? ContactId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingAccConView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MAILING_ACC_CON_VIEW");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkType)
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
