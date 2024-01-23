namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsCompetitorRoomtypes
{
    public string Resort { get; set; }
    public string ShopperCode { get; set; }
    public string CompetitorResort { get; set; }
    public string TravelsiteCode { get; set; }
    public string TravelsiteRoomtypeCode { get; set; }
    public string TravelsiteRoomDesc { get; set; }
    public string OperaRoomCategory { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual OrmsCompetitorTravelsites OrmsCompetitorTravelsites { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsCompetitorRoomtypes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ShopperCode, e.CompetitorResort, e.TravelsiteCode, e.TravelsiteRoomtypeCode })
                .HasName("ORMS_COMP_TRVLROOMS_PK");

            entity.ToTable("ORMS_COMPETITOR_ROOMTYPES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShopperCode)
                .HasColumnName("SHOPPER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompetitorResort)
                .HasColumnName("COMPETITOR_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteCode)
                .HasColumnName("TRAVELSITE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteRoomtypeCode)
                .HasColumnName("TRAVELSITE_ROOMTYPE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OperaRoomCategory)
                .HasColumnName("OPERA_ROOM_CATEGORY")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteRoomDesc)
                .IsRequired()
                .HasColumnName("TRAVELSITE_ROOM_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsCompetitorTravelsites)))
				entity.Ignore(e => e.OrmsCompetitorTravelsites);
			else
	            entity.HasOne(d => d.OrmsCompetitorTravelsites)
	                .WithMany(p => p.OrmsCompetitorRoomtypes)
	                .HasForeignKey(d => new { d.Resort, d.ShopperCode, d.CompetitorResort, d.TravelsiteCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_COMP_TRVROOMS_PK");
        });
	}
}
