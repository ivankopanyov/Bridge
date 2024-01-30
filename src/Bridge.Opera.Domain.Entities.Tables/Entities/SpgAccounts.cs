namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SpgAccounts
{
    public decimal? SetNumber { get; set; }
    public string? AccountName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpgAccounts>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SPG_ACCOUNTS");

            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SetNumber)
                .HasColumnName("SET_NUMBER")
                .HasColumnType("NUMBER");
        });
	}
}
