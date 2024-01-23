namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfilePrefs
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public string PreferenceType { get; set; }
    public string PreferenceValue { get; set; }
    public string Requestcomments { get; set; }
    public string ValidYn { get; set; }
    public string ErrorDesc { get; set; }
    public string ResortPref { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual StageProfiles ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfilePrefs>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_PREFS");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId, e.PreferenceType, e.PreferenceValue, e.ResortPref })
                .HasName("STAGE_PROF_PREF_IND1")
                .IsUnique();

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PreferenceType)
                .IsRequired()
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceValue)
                .IsRequired()
                .HasColumnName("PREFERENCE_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Requestcomments)
                .HasColumnName("REQUESTCOMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortPref)
                .HasColumnName("RESORT_PREF")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageProfiles)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.ResortNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_PROF_PREF_FK1");
        });
	}
}
