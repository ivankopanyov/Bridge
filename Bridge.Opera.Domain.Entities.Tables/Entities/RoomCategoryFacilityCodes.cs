namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomCategoryFacilityCodes
{
    public string Resort { get; set; }
    public string RoomCategory { get; set; }
    public string FacilityTask { get; set; }
    public string FacilityCode { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? FacilityTaskSeq { get; set; }

    public virtual RoomCategoryFacilityTasks FacilityTaskSeqNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomCategoryFacilityCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ROOM_CATEGORY_FACILITY_CODES");

            entity.HasIndex(e => new { e.FacilityTaskSeq, e.FacilityCode })
                .HasName("ROOM_CAT_FACILITY_CODES_UK")
                .IsUnique();

            entity.Property(e => e.FacilityCode)
                .IsRequired()
                .HasColumnName("FACILITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FacilityTask)
                .IsRequired()
                .HasColumnName("FACILITY_TASK")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FacilityTaskSeq)
                .HasColumnName("FACILITY_TASK_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RoomCategoryFacilityTasks)))
				entity.Ignore(e => e.FacilityTaskSeqNavigation);
			else
	            entity.HasOne(d => d.FacilityTaskSeqNavigation)
	                .WithMany()
	                .HasPrincipalKey(p => p.FacilityTaskSeq)
	                .HasForeignKey(d => d.FacilityTaskSeq)
	                .HasConstraintName("ROOM_CAT_FACILITY_CODES_FK");
        });
	}
}
