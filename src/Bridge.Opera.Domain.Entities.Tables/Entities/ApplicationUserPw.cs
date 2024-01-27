namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ApplicationUserPw
{
    public decimal AppUserId { get; set; }
    public string Password { get; set; }
    public string Terminal { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

    public virtual ApplicationUser AppUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ApplicationUserPw>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("APPLICATION_USER_PW");

            entity.HasIndex(e => e.AppUserId)
                .HasName("AUP_FKI");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("PASSWORD")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.AppUser);
			else
	            entity.HasOne(d => d.AppUser)
	                .WithMany()
	                .HasForeignKey(d => d.AppUserId)
	                .HasConstraintName("AUPW_AUSR_FK");
        });
	}
}
