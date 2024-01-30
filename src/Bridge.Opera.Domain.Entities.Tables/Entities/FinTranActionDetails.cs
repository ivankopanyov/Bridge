namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FinTranActionDetails
{
    public decimal? FinActionId { get; set; }
    public decimal? Piece { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string? Room { get; set; }
    public string? ProcessFlow { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranActionDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FIN_TRAN_ACTION_DETAILS");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate })
                .HasName("FTAD_RES_BDATE_IDX");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FinActionId)
                .HasColumnName("FIN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Piece)
                .HasColumnName("PIECE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessFlow)
                .HasColumnName("PROCESS_FLOW")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
