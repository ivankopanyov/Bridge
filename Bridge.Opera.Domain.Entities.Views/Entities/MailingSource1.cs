namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MailingSource1
{
    public decimal QueryIdLink { get; set; }
    public string TableName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingSource1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MAILING_SOURCE");

            entity.Property(e => e.QueryIdLink)
                .HasColumnName("QUERY_ID_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
