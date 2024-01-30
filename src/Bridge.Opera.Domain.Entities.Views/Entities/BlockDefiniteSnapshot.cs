namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BlockDefiniteSnapshot
{
    public string? SourceSystem { get; set; }
    public string? PropertyCode { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? ArriveDate { get; set; }
    public string? Udfc02 { get; set; }
    public string? Bookingtype { get; set; }
    public string? CreateOwnerCode { get; set; }
    public decimal? DefPeakRoomsBlocked { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BlockDefiniteSnapshot>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BLOCK_DEFINITE_SNAPSHOT");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArriveDate)
                .HasColumnName("ARRIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Bookingtype)
                .HasColumnName("BOOKINGTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreateOwnerCode)
                .HasColumnName("CREATE_OWNER_CODE")
                .IsUnicode(false);

            entity.Property(e => e.DefPeakRoomsBlocked)
                .HasColumnName("DEF_PEAK_ROOMS_BLOCKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PropertyCode)
                .IsRequired()
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
