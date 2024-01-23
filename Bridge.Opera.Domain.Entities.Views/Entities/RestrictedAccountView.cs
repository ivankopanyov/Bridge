namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RestrictedAccountView
{
    public decimal NameId { get; set; }
    public string NameType { get; set; }
    public string Name { get; set; }
    public string Name2 { get; set; }
    public string Name3 { get; set; }
    public string City { get; set; }
    public string PhoneNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RestrictedAccountView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESTRICTED_ACCOUNT_VIEW");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .IsUnicode(false);
        });
	}
}
