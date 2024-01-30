namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InventoryqueryTable
{
    public decimal? Keynumber { get; set; }
    public string? QueryType { get; set; }
    public string? ChainCode { get; set; }
    public string? HotelCode { get; set; }
    public string? TimeUnitType { get; set; }
    public DateTime? StartTime { get; set; }
    public decimal? NumberOfTimeUnits { get; set; }
    public string? RoomType { get; set; }
    public string? Status { get; set; }
    public string? ProcessingMsg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InventoryqueryTable>(entity =>
        {
            entity.HasKey(e => e.Keynumber)
                .HasName("INVREQ_PK");

            entity.ToTable("INVENTORYQUERY_TABLE");

            entity.Property(e => e.Keynumber)
                .HasColumnName("KEYNUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NumberOfTimeUnits)
                .HasColumnName("NUMBER_OF_TIME_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessingMsg)
                .HasColumnName("PROCESSING_MSG")
                .IsUnicode(false);

            entity.Property(e => e.QueryType)
                .HasColumnName("QUERY_TYPE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimeUnitType)
                .HasColumnName("TIME_UNIT_TYPE")
                .HasMaxLength(6)
                .IsUnicode(false);
        });
	}
}
