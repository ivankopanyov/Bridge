namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FacilityCodesForRoomtypes
{
    public string? Resort { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? FacilityTask { get; set; }
    public string? TaskDescription { get; set; }
    public string? FacilityCode { get; set; }
    public string? FacilityCodeDescription { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? FacilityTaskSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FacilityCodesForRoomtypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FACILITY_CODES_FOR_ROOMTYPES");

            entity.Property(e => e.FacilityCode)
                .IsRequired()
                .HasColumnName("FACILITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FacilityCodeDescription)
                .HasColumnName("FACILITY_CODE_DESCRIPTION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FacilityTask)
                .IsRequired()
                .HasColumnName("FACILITY_TASK")
                .HasMaxLength(20)
                .IsUnicode(false);

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
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskDescription)
                .IsRequired()
                .HasColumnName("TASK_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
