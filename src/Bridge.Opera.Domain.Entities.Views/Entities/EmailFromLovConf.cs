namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EmailFromLovConf
{
    public string? Email { get; set; }
    public decimal? Orderby { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmailFromLovConf>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EMAIL_FROM_LOV_CONF");

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
