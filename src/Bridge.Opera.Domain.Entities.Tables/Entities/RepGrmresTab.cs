namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RepGrmresTab
{
    public decimal? BookId { get; set; }
    public string? Resort { get; set; }
    public string? RoomCode { get; set; }
    public decimal? RoomOrder { get; set; }
    public decimal? RoomSort { get; set; }
    public string? GridType { get; set; }
    public decimal? GridGroup { get; set; }
    public decimal? GridOrder { get; set; }
    public string? XCell { get; set; }
    public string? XFormat { get; set; }
    public DateTime? YCell { get; set; }
    public string? Cell { get; set; }
    public string? CellFormat { get; set; }
    public decimal? CellRoomCount { get; set; }
    public decimal? CellRoomRate { get; set; }
    public decimal? MasterBookId { get; set; }
    public string? MasterResort { get; set; }
    public string? MasterType { get; set; }
    public decimal? MasterOrder { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepGrmresTab>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("REP_GRMRES_TAB");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cell)
                .HasColumnName("CELL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CellFormat)
                .HasColumnName("CELL_FORMAT")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.CellRoomCount)
                .HasColumnName("CELL_ROOM_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CellRoomRate)
                .HasColumnName("CELL_ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GridGroup)
                .HasColumnName("GRID_GROUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GridOrder)
                .HasColumnName("GRID_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GridType)
                .HasColumnName("GRID_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MasterBookId)
                .HasColumnName("MASTER_BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterOrder)
                .HasColumnName("MASTER_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterResort)
                .HasColumnName("MASTER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterType)
                .HasColumnName("MASTER_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCode)
                .HasColumnName("ROOM_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomOrder)
                .HasColumnName("ROOM_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomSort)
                .HasColumnName("ROOM_SORT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XCell)
                .HasColumnName("X_CELL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.XFormat)
                .HasColumnName("X_FORMAT")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.YCell)
                .HasColumnName("Y_CELL")
                .HasColumnType("DATE");
        });
	}
}
