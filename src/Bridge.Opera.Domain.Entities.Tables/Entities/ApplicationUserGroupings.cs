namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ApplicationUserGroupings
{
    public decimal AppUserId { get; set; }
    public string Resort { get; set; }
    public decimal AppUserIdMember { get; set; }
    public string ProxyOfAppUserIdYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

    public virtual ApplicationUser AppUser { get; set; }
    public virtual ApplicationUser AppUserIdMemberNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ApplicationUserGroupings>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AppUserIdMember, e.ProxyOfAppUserIdYn, e.AppUserId })
                .HasName("APP_USER_GROUPINGS_PK");

            entity.ToTable("APPLICATION_USER_GROUPINGS");

            entity.HasIndex(e => e.AppUserId)
                .HasName("APP_USER_OWNER_FK_I");

            entity.HasIndex(e => e.AppUserIdMember)
                .HasName("APP_USER_MEMBER_FK_I");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AppUserIdMember)
                .HasColumnName("APP_USER_ID_MEMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProxyOfAppUserIdYn)
                .HasColumnName("PROXY_OF_APP_USER_ID_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.AppUser);
			else
	            entity.HasOne(d => d.AppUser)
	                .WithMany(p => p.ApplicationUserGroupingsAppUser)
	                .HasForeignKey(d => d.AppUserId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("APP_USER_OWNER_FK");

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.AppUserIdMemberNavigation);
			else
	            entity.HasOne(d => d.AppUserIdMemberNavigation)
	                .WithMany(p => p.ApplicationUserGroupingsAppUserIdMemberNavigation)
	                .HasForeignKey(d => d.AppUserIdMember)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("APP_USER_MEMBER_FK");
        });
	}
}
