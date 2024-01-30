namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempAppUserGrp
{
    public decimal? AppUserId { get; set; }
    public decimal? AppUserIdMember { get; set; }
    public string? Action { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempAppUserGrp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_APP_USER_GRP");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppUserIdMember)
                .HasColumnName("APP_USER_ID_MEMBER")
                .HasColumnType("NUMBER");
        });
	}
}
