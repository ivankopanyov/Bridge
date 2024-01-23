namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsConvRoomCategories
{
    public string GdsHost { get; set; }
    public string Resort { get; set; }
    public string RoomCategory { get; set; }
    public string GdsRoomCategory { get; set; }
    public string GdsRoomDescription { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal? GdsRoomOrder { get; set; }
    public string RoomCreateYn { get; set; }
    public DateTime? RoomUpdateDate { get; set; }
    public string ActivateYn { get; set; }
    public string GdsBedTypeCode { get; set; }
    public decimal? SellSequence { get; set; }
    public string Rd1 { get; set; }
    public string Rd2 { get; set; }
    public string Rd3 { get; set; }
    public decimal? BaseAllocation { get; set; }
    public string GdsRoomCodeName { get; set; }
    public string GdsRoomShortDesc { get; set; }
    public decimal? ThresholdRti { get; set; }
    public string RoomViewCode { get; set; }
    public string RoomQualCode { get; set; }

    public virtual GdsConvResorts GdsConvResorts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsConvRoomCategories>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_CONV_ROOM_CATEGORIES");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.GdsRoomCategory })
                .HasName("GDS_ROOM_CATEGORY_IND2");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.RoomCategory })
                .HasName("GDS_ROOM_CATEGORY_IND1");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.RoomCategory, e.BeginDate })
                .HasName("GDS_CONV_ROOM_CATEGORY_IND3");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.RoomCategory, e.GdsRoomCategory, e.BeginDate })
                .HasName("GDS_CONV_ROOM_UN")
                .IsUnique();

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.BaseAllocation)
                .HasColumnName("BASE_ALLOCATION")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsBedTypeCode)
                .HasColumnName("GDS_BED_TYPE_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRoomCategory)
                .IsRequired()
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRoomCodeName)
                .HasColumnName("GDS_ROOM_CODE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRoomDescription)
                .HasColumnName("GDS_ROOM_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRoomOrder)
                .HasColumnName("GDS_ROOM_ORDER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRoomShortDesc)
                .HasColumnName("GDS_ROOM_SHORT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rd1)
                .HasColumnName("RD1")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rd2)
                .HasColumnName("RD2")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rd3)
                .HasColumnName("RD3")
                .HasMaxLength(200)
                .IsUnicode(false)
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

            entity.Property(e => e.RoomCreateYn)
                .IsRequired()
                .HasColumnName("ROOM_CREATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.RoomQualCode)
                .HasColumnName("ROOM_QUAL_CODE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomUpdateDate)
                .HasColumnName("ROOM_UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomViewCode)
                .HasColumnName("ROOM_VIEW_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ThresholdRti)
                .HasColumnName("THRESHOLD_RTI")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsConvResorts)))
				entity.Ignore(e => e.GdsConvResorts);
			else
	            entity.HasOne(d => d.GdsConvResorts)
	                .WithMany()
	                .HasForeignKey(d => new { d.GdsHost, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GDS_CONV_ROOM_GDS_CONV_RES_FK");
        });
	}
}
