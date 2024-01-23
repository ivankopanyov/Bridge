namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationFeatures
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal PreferenceSeqId { get; set; }
    public string ExternalFeatureId { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual Preferences PreferenceSeq { get; set; }
    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationFeatures>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.PreferenceSeqId })
                .HasName("RESERVATION_FEATURES_PK");

            entity.ToTable("RESERVATION_FEATURES");

            entity.HasIndex(e => e.PreferenceSeqId)
                .HasName("RESERVATION_FEATURES_FKI2");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreferenceSeqId)
                .HasColumnName("PREFERENCE_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalFeatureId)
                .HasColumnName("EXTERNAL_FEATURE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Preferences)))
				entity.Ignore(e => e.PreferenceSeq);
			else
	            entity.HasOne(d => d.PreferenceSeq)
	                .WithMany(p => p.ReservationFeatures)
	                .HasPrincipalKey(p => p.PreferenceSeqId)
	                .HasForeignKey(d => d.PreferenceSeqId)
	                .HasConstraintName("RESERVATION_FEATURES_FK2");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationFeatures)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("RESERVATION_FEATURES_FK1");
        });
	}
}
