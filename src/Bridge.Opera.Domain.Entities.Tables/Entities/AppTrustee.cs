namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppTrustee
{
    public AppTrustee()
    {
        AppTrusteePermission = new HashSet<AppTrusteePermission>();
    }

    public decimal AppTrusteeId { get; set; }
    public decimal AppUserId { get; set; }
    public decimal TrusteeId { get; set; }
    public string Resort { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ApplicationUser AppUser { get; set; }
    public virtual ICollection<AppTrusteePermission> AppTrusteePermission { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppTrustee>(entity =>
        {
            entity.ToTable("APP$_TRUSTEE");

            entity.HasIndex(e => e.AppUserId)
                .HasName("APP_TRUSTEE_USER_IDX");

            entity.HasIndex(e => e.TrusteeId)
                .HasName("APP_TRUSTEE_ID_IDX");

            entity.Property(e => e.AppTrusteeId)
                .HasColumnName("APP_TRUSTEE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrusteeId)
                .HasColumnName("TRUSTEE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.AppUser);
			else
	            entity.HasOne(d => d.AppUser)
	                .WithMany(p => p.AppTrustee)
	                .HasForeignKey(d => d.AppUserId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("APPTRU_APPUSR_FK");
        
			if (!types.Contains(typeof(AppTrusteePermission)))
				entity.Ignore(e => e.AppTrusteePermission);
		});
	}
}
