namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortAirports
{
    public string Resort { get; set; }
    public string AirportCode { get; set; }
    public decimal? DistanceFromAirport { get; set; }
    public string DistanceUnits { get; set; }
    public string DirectionFromAirport { get; set; }
    public string Transportation1 { get; set; }
    public string Transportation2 { get; set; }
    public string Transportation3 { get; set; }
    public string Transportation4 { get; set; }
    public string Transportation5 { get; set; }
    public string Transportation6 { get; set; }
    public string Transportation7 { get; set; }
    public string Transportation8 { get; set; }
    public decimal? OrderBy { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string DrivingTime { get; set; }
    public string Website { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortAirports>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AirportCode })
                .HasName("RES_AIRPT_PK");

            entity.ToTable("RESORT_AIRPORTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AirportCode)
                .HasColumnName("AIRPORT_CODE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DirectionFromAirport)
                .HasColumnName("DIRECTION_FROM_AIRPORT")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DistanceFromAirport)
                .HasColumnName("DISTANCE_FROM_AIRPORT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DistanceUnits)
                .HasColumnName("DISTANCE_UNITS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DrivingTime)
                .HasColumnName("DRIVING_TIME")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Transportation1)
                .HasColumnName("TRANSPORTATION_1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Transportation2)
                .HasColumnName("TRANSPORTATION_2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Transportation3)
                .HasColumnName("TRANSPORTATION_3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Transportation4)
                .HasColumnName("TRANSPORTATION_4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Transportation5)
                .HasColumnName("TRANSPORTATION_5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Transportation6)
                .HasColumnName("TRANSPORTATION_6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Transportation7)
                .HasColumnName("TRANSPORTATION_7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Transportation8)
                .HasColumnName("TRANSPORTATION_8")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Website)
                .HasColumnName("WEBSITE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
