namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationOverrides
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? ResvOverrideId { get; set; }
    public string? OverrideType { get; set; }
    public DateTime? OverrideDate { get; set; }
    public decimal? OverrideBy { get; set; }
    public string? OverrideReason { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UserOverrideReasonCode { get; set; }
    public string? UserOverrideReasonDesc { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationOverrides>(entity =>
        {
            entity.HasKey(e => e.ResvOverrideId)
                .HasName("RESERVATION_OVERRIDES_PK");

            entity.ToTable("RESERVATION_OVERRIDES");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("RESERVATION_OVERRIDES_IND1");

            entity.Property(e => e.ResvOverrideId)
                .HasColumnName("RESV_OVERRIDE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideBy)
                .HasColumnName("OVERRIDE_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideDate)
                .HasColumnName("OVERRIDE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideReason)
                .HasColumnName("OVERRIDE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideType)
                .IsRequired()
                .HasColumnName("OVERRIDE_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserOverrideReasonCode)
                .HasColumnName("USER_OVERRIDE_REASON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserOverrideReasonDesc)
                .HasColumnName("USER_OVERRIDE_REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationOverrides)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_OVERRIDES_FK1");
        });
	}
}
