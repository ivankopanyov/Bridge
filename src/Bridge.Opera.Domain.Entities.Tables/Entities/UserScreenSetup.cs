namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UserScreenSetup
{
    public decimal? AppUserId { get; set; }
    public decimal? SetupId { get; set; }
    public string? UdfField { get; set; }
    public string? Description { get; set; }

    public virtual ApplicationUser AppUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserScreenSetup>(entity =>
        {
            entity.HasKey(e => e.AppUserId)
                .HasName("USER_SCREEN_SETUP_PK");

            entity.ToTable("USER_SCREEN_SETUP");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SetupId)
                .HasColumnName("SETUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UdfField)
                .HasColumnName("UDF_FIELD")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.AppUser);
			else
	            entity.HasOne(d => d.AppUser)
	                .WithOne(p => p.UserScreenSetup)
	                .HasForeignKey<UserScreenSetup>(d => d.AppUserId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("USER_SCREEN_SETUP_FK1");
        });
	}
}
