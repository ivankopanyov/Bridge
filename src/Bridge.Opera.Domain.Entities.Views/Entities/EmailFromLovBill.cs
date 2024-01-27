namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EmailFromLovBill
{
    public string Email { get; set; }
    public decimal? Orderby { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmailFromLovBill>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EMAIL_FROM_LOV_BILL");

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Orderby)
                .HasColumnName("ORDERBY")
                .HasColumnType("NUMBER");
        });
	}
}
