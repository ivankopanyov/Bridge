namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfilePhones
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public string PhoneType { get; set; }
    public string PhoneRole { get; set; }
    public string PhoneNumber { get; set; }
    public string Countryaccessnumber { get; set; }
    public string Citycode { get; set; }
    public string Phoneextension { get; set; }
    public string ValidYn { get; set; }
    public string ErrorDesc { get; set; }
    public string PrimaryYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string DefaultConfirmationYn { get; set; }

    public virtual StageProfiles ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfilePhones>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId, e.PhoneType, e.PhoneNumber })
                .HasName("STAGE_PROF_PHONE_PK");

            entity.ToTable("STAGE_PROFILE_PHONES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Citycode)
                .HasColumnName("CITYCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Countryaccessnumber)
                .HasColumnName("COUNTRYACCESSNUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultConfirmationYn)
                .HasColumnName("DEFAULT_CONFIRMATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PhoneRole)
                .HasColumnName("PHONE_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Phoneextension)
                .HasColumnName("PHONEEXTENSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageProfiles)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.StageProfilePhones)
	                .HasForeignKey(d => new { d.Resort, d.ResortNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_PROF_PHONE_FK1");
        });
	}
}
