namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationPreferences
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? PreferenceId { get; set; }
    public string? PreferenceType { get; set; }
    public string? Preference { get; set; }
    public string? Comments { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public string? Source { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? PreArrivalDt { get; set; }
    public string? ExternalPreferenceId { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationPreferences>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESERVATION_PREFERENCES");

            entity.HasIndex(e => e.ExternalPreferenceId)
                .HasName("RESV_PREF_EXTID_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.PreferenceId })
                .HasName("RESV_PREF_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.PreferenceType, e.Preference })
                .HasName("RESV_PREF_TYPE_UK")
                .IsUnique();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(250)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalPreferenceId)
                .HasColumnName("EXTERNAL_PREFERENCE_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreArrivalDt)
                .HasColumnName("PRE_ARRIVAL_DT")
                .HasColumnType("DATE");

            entity.Property(e => e.Preference)
                .IsRequired()
                .HasColumnName("PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceId)
                .HasColumnName("PREFERENCE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreferenceType)
                .IsRequired()
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("RESV_PREF_FK");
        });
	}
}
