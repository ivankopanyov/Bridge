namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExtSystems
{
    public ExtSystems()
    {
        ActionTypeMandWhere = new HashSet<ActionTypeMandWhere>();
        ActionTypeSubscription = new HashSet<ActionTypeSubscription>();
        ExtSystemsSubscription = new HashSet<ExtSystemsSubscription>();
    }

    public string? Code { get; set; }
    public string? Description { get; set; }
    public decimal? SeqNo { get; set; }
    public decimal? AppUserId { get; set; }
    public string? DisplayYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? PmsType { get; set; }
    public string? LookupYn { get; set; }
    public string? SystemType { get; set; }
    public string? ValidateLoginUrl { get; set; }
    public string? SsoExternalValidationUrl { get; set; }
    public string? ExternalUri { get; set; }
    public string? NameLookupFields { get; set; }
    public string? BatchBe { get; set; }

    public virtual ApplicationUser AppUser { get; set; }
    public virtual ICollection<ActionTypeMandWhere> ActionTypeMandWhere { get; set; }
    public virtual ICollection<ActionTypeSubscription> ActionTypeSubscription { get; set; }
    public virtual ICollection<ExtSystemsSubscription> ExtSystemsSubscription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtSystems>(entity =>
        {
            entity.HasKey(e => e.Code)
                .HasName("EXTSYS_PK");

            entity.ToTable("EXT_SYSTEMS");

            entity.HasIndex(e => e.AppUserId)
                .HasName("EXTSYS_UK")
                .IsUnique();

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchBe)
                .HasColumnName("BATCH_BE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .IsRequired()
                .HasColumnName("DISPLAY_YN")
                .HasColumnType("CHAR(1)")
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.ExternalUri)
                .HasColumnName("EXTERNAL_URI")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("SYSDATE ");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LookupYn)
                .IsRequired()
                .HasColumnName("LOOKUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.NameLookupFields)
                .HasColumnName("NAME_LOOKUP_FIELDS")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.PmsType)
                .HasColumnName("PMS_TYPE")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SsoExternalValidationUrl)
                .HasColumnName("SSO_EXTERNAL_VALIDATION_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SystemType)
                .HasColumnName("SYSTEM_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("SYSDATE ");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidateLoginUrl)
                .HasColumnName("VALIDATE_LOGIN_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(ApplicationUser)))
				entity.Ignore(e => e.AppUser);
			else
	            entity.HasOne(d => d.AppUser)
	                .WithOne(p => p.ExtSystems)
	                .HasForeignKey<ExtSystems>(d => d.AppUserId)
	                .HasConstraintName("EXTSYS_APPLICATION_USER_FK");
        
			if (!types.Contains(typeof(ActionTypeMandWhere)))
				entity.Ignore(e => e.ActionTypeMandWhere);

			if (!types.Contains(typeof(ActionTypeSubscription)))
				entity.Ignore(e => e.ActionTypeSubscription);

			if (!types.Contains(typeof(ExtSystemsSubscription)))
				entity.Ignore(e => e.ExtSystemsSubscription);
		});
	}
}
