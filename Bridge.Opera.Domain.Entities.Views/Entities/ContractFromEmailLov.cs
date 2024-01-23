namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ContractFromEmailLov
{
    public string Email { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ContractFromEmailLov>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CONTRACT_FROM_EMAIL_LOV");

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
