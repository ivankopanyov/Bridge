namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HurdleRatesJrnl
{
    public decimal ActionInstanceId { get; set; }
    public decimal DmlSeqNo { get; set; }
    public string UDFlag { get; set; }
    public string Resort { get; set; }
    public DateTime? HurdleDate { get; set; }
    public string RoomCategory { get; set; }
    public string YieldCategory { get; set; }
    public decimal? Los { get; set; }
    public string RoomCategoryLabel { get; set; }
    public decimal? Delta { get; set; }
    public decimal? Hurdle { get; set; }
    public string Override { get; set; }
    public decimal? Upsolds { get; set; }
    public decimal? Ceiling { get; set; }
    public decimal? Maxsolds { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string YmCode { get; set; }
    public decimal? OrmsPriceRoomDelta { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HurdleRatesJrnl>(entity =>
        {
            entity.HasKey(e => new { e.ActionInstanceId, e.DmlSeqNo })
                .HasName("HURDLE_RATES_PK");

            entity.ToTable("HURDLE_RATES_JRNL");

            entity.HasIndex(e => new { e.Resort, e.HurdleDate, e.Los, e.YieldCategory, e.RoomCategory })
                .HasName("HURDLE_RATES_JRNL_DATE");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ceiling)
                .HasColumnName("CEILING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Delta)
                .HasColumnName("DELTA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Hurdle)
                .HasColumnName("HURDLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleDate)
                .HasColumnName("HURDLE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Maxsolds)
                .HasColumnName("MAXSOLDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsPriceRoomDelta)
                .HasColumnName("ORMS_PRICE_ROOM_DELTA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Override)
                .HasColumnName("OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UDFlag)
                .HasColumnName("U_D_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Upsolds)
                .HasColumnName("UPSOLDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YmCode)
                .HasColumnName("YM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
