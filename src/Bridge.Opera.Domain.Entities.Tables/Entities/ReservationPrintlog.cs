namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationPrintlog
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal PrintlogSeqno { get; set; }
    public string PrintedYn { get; set; }
    public string PrintText { get; set; }
    public decimal? PrintRetries { get; set; }
    public string InsertTerminal { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationPrintlog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESERVATION_PRINTLOG");

            entity.HasIndex(e => new { e.Resort, e.PrintedYn, e.PrintlogSeqno })
                .HasName("RPL_RES_STAT_SEQ");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertTerminal)
                .HasColumnName("INSERT_TERMINAL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintRetries)
                .HasColumnName("PRINT_RETRIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintText)
                .HasColumnName("PRINT_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.PrintedYn)
                .HasColumnName("PRINTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PrintlogSeqno)
                .HasColumnName("PRINTLOG_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
