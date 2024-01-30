namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExtSystemsUsers
{
    public decimal? AppUserId { get; set; }
    public string? Resort { get; set; }
    public string? ExtSystemCode { get; set; }
    public string? ExternalId { get; set; }
    public string? InToken { get; set; }
    public DateTime? InTokenexpTs { get; set; }
    public string? OutToken { get; set; }
    public DateTime? OutTokenexpTs { get; set; }
    public string? LoginYn { get; set; }
    public string? Sourcememberid { get; set; }
    public DateTime? InTokenRcvTs { get; set; }

    public virtual ApplicationUser AppUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtSystemsUsers>(entity =>
        {
            entity.HasKey(e => new { e.AppUserId, e.Resort, e.ExtSystemCode })
                .HasName("ESUSR_PK");

            entity.ToTable("EXT_SYSTEMS_USERS");

            entity.HasIndex(e => new { e.InToken, e.ExtSystemCode })
                .HasName("EXT_SYSTEMS_USER_IDX1");

            entity.HasIndex(e => new { e.Resort, e.ExtSystemCode, e.ExternalId })
                .HasName("ESUSR_UK")
                .IsUnique();

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtSystemCode)
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExternalId)
                .IsRequired()
                .HasColumnName("EXTERNAL_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InToken)
                .HasColumnName("IN_TOKEN")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InTokenRcvTs)
                .HasColumnName("IN_TOKEN_RCV_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.InTokenexpTs)
                .HasColumnName("IN_TOKENEXP_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.LoginYn)
                .HasColumnName("LOGIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OutToken)
                .HasColumnName("OUT_TOKEN")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OutTokenexpTs)
                .HasColumnName("OUT_TOKENEXP_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.Sourcememberid)
                .HasColumnName("SOURCEMEMBERID")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.AppUser);
			else
	            entity.HasOne(d => d.AppUser)
	                .WithMany(p => p.ExtSystemsUsers)
	                .HasForeignKey(d => d.AppUserId)
	                .HasConstraintName("ESUSR_AUR_FK");
        });
	}
}
