namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QmsLocations
{
    public string Resort { get; set; }
    public decimal? LAccScore { get; set; }
    public string LocationCode { get; set; }
    public string Description { get; set; }
    public string ApplicableToPmYn { get; set; }
    public string GuestRoomYn { get; set; }
    public string ApplicableToSncYn { get; set; }
    public string ActiveYn { get; set; }
    public string PriorityCode { get; set; }
    public string UsedInApp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QmsLocations>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QMS_LOCATIONS");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ApplicableToPmYn)
                .HasColumnName("APPLICABLE_TO_PM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ApplicableToSncYn)
                .HasColumnName("APPLICABLE_TO_SNC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestRoomYn)
                .HasColumnName("GUEST_ROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LAccScore)
                .HasColumnName("L_ACC_SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocationCode)
                .IsRequired()
                .HasColumnName("LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriorityCode)
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsedInApp)
                .IsRequired()
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
