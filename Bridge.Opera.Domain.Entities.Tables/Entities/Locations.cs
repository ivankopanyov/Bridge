namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Locations
{
    public Locations()
    {
        PlantItems = new HashSet<PlantItems>();
        RoomInspections = new HashSet<RoomInspections>();
        WorkOrders = new HashSet<WorkOrders>();
    }

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

    public virtual Priorities Priorities { get; set; }
    public virtual ICollection<PlantItems> PlantItems { get; set; }
    public virtual ICollection<RoomInspections> RoomInspections { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Locations>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.LocationCode })
                .HasName("LOC1_PK");

            entity.ToTable("LOCATIONS");

            entity.HasIndex(e => new { e.Resort, e.PriorityCode })
                .HasName("LOC1_PRI_FK_I");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocationCode)
                .HasColumnName("LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ApplicableToPmYn)
                .HasColumnName("APPLICABLE_TO_PM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ApplicableToSncYn)
                .HasColumnName("APPLICABLE_TO_SNC_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestRoomYn)
                .HasColumnName("GUEST_ROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.LAccScore)
                .HasColumnName("L_ACC_SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorityCode)
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsedInApp)
                .IsRequired()
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'QMS'");

			if (!types.Contains(typeof(Priorities)))
				entity.Ignore(e => e.Priorities);
			else
	            entity.HasOne(d => d.Priorities)
	                .WithMany(p => p.Locations)
	                .HasForeignKey(d => new { d.Resort, d.PriorityCode })
	                .HasConstraintName("LOC1_PRI_FK");
        
			if (!types.Contains(typeof(PlantItems)))
				entity.Ignore(e => e.PlantItems);

			if (!types.Contains(typeof(RoomInspections)))
				entity.Ignore(e => e.RoomInspections);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
