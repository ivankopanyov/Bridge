namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScRoomtypeMapping
{
    public decimal MapId { get; set; }
    public string Resort { get; set; }
    public string ScRoomCategory { get; set; }
    public string PmsRoomCategory { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string ScResort { get; set; }
    public string ScReturnCategory { get; set; }

    public virtual ScRoomtypes ScR { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScRoomtypeMapping>(entity =>
        {
            entity.HasKey(e => e.MapId)
                .HasName("SRM_PK");

            entity.ToTable("SC_ROOMTYPE_MAPPING");

            entity.HasIndex(e => new { e.Resort, e.PmsRoomCategory })
                .HasName("SRM_RESORT_PR_IDX");

            entity.HasIndex(e => new { e.ScResort, e.ScRoomCategory })
                .HasName("SRM_SR_FK_IDX");

            entity.HasIndex(e => new { e.ScResort, e.ScReturnCategory, e.Resort })
                .HasName("SRM_RESORT_RETURN_IDX");

            entity.Property(e => e.MapId)
                .HasColumnName("MAP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsRoomCategory)
                .IsRequired()
                .HasColumnName("PMS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScResort)
                .IsRequired()
                .HasColumnName("SC_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScReturnCategory)
                .HasColumnName("SC_RETURN_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScRoomCategory)
                .HasColumnName("SC_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ScRoomtypes)))
				entity.Ignore(e => e.ScR);
			else
	            entity.HasOne(d => d.ScR)
	                .WithMany(p => p.ScRoomtypeMapping)
	                .HasForeignKey(d => new { d.ScResort, d.ScRoomCategory })
	                .HasConstraintName("SRM_SR_FK");
        });
	}
}
