namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UserBiGroupsLink
{
    public decimal? AppUserId { get; set; }
    public string? BiGroupCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserBiGroupsLink>(entity =>
        {
            entity.HasKey(e => new { e.AppUserId, e.BiGroupCode })
                .HasName("USER_BI_GROUPS_LINK_PK");

            entity.ToTable("USER_BI_GROUPS_LINK");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BiGroupCode)
                .HasColumnName("BI_GROUP_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
