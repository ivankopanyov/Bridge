namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UserChainAccessLink
{
    public decimal AppUserId { get; set; }
    public string ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserChainAccessLink>(entity =>
        {
            entity.HasKey(e => new { e.AppUserId, e.ChainCode })
                .HasName("USER_CHAIN_ACCESS_PK");

            entity.ToTable("USER_CHAIN_ACCESS_LINK");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
