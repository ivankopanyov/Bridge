namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsCompetitorData
{
    public string? Resort { get; set; }
    public string? ShopperCode { get; set; }
    public string? CompetitorResort { get; set; }
    public string? TravelsiteCode { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public decimal? Los { get; set; }
    public string? TravelsiteRateCode { get; set; }
    public string? TravelsiteRoomtypeCode { get; set; }
    public string? AvailabilityStatus { get; set; }
    public decimal? Amount1 { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual OrmsCompetitorTravelsites OrmsCompetitorTravelsites { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsCompetitorData>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ShopperCode, e.CompetitorResort, e.TravelsiteCode, e.ArrivalDate, e.Los, e.TravelsiteRateCode, e.TravelsiteRoomtypeCode })
                .HasName("ORMS_COMP_DATA_PK");

            entity.ToTable("ORMS_COMPETITOR_DATA");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShopperCode)
                .HasColumnName("SHOPPER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompetitorResort)
                .HasColumnName("COMPETITOR_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TravelsiteCode)
                .HasColumnName("TRAVELSITE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("1 ");

            entity.Property(e => e.TravelsiteRateCode)
                .HasColumnName("TRAVELSITE_RATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TravelsiteRoomtypeCode)
                .HasColumnName("TRAVELSITE_ROOMTYPE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Amount1)
                .HasColumnName("AMOUNT_1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AvailabilityStatus)
                .IsRequired()
                .HasColumnName("AVAILABILITY_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'A'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
	                .WithMany(p => p.OrmsCompetitorData)
	                .HasForeignKey(d => new { d.Resort, d.ShopperCode, d.CompetitorResort, d.TravelsiteCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_COMP_TRAVELDATA_FK");
        });
	}
}
