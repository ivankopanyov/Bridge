namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RestrictedContactView
{
    public decimal NameId { get; set; }
    public string NameType { get; set; }
    public string Name { get; set; }
    public string First { get; set; }
    public string Last { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RestrictedContactView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESTRICTED_CONTACT_VIEW");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .IsUnicode(false);

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .IsUnicode(false);
        });
	}
}
