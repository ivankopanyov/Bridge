namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MailingAccConLinkView
{
    public decimal? AccountId { get; set; }
    public decimal? ContactId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingAccConLinkView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MAILING_ACC_CON_LINK_VIEW");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
