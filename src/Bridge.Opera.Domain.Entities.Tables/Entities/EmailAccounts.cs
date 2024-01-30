namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EmailAccounts
{
    public decimal? AppUserId { get; set; }
    public string? Email { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ApplicationUser AppUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmailAccounts>(entity =>
        {
            entity.HasKey(e => new { e.AppUserId, e.Email })
                .HasName("EMAILACC_PK");

            entity.ToTable("EMAIL_ACCOUNTS");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Username)
                .HasColumnName("USERNAME")
                .HasMaxLength(100)
                .IsUnicode(false);

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.AppUser);
			else
	            entity.HasOne(d => d.AppUser)
	                .WithMany(p => p.EmailAccounts)
	                .HasForeignKey(d => d.AppUserId)
	                .HasConstraintName("EMAILACC_APPUSR_FK");
        });
	}
}
