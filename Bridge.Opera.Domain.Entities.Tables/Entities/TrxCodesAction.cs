namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxCodesAction
{
    public string Terminal { get; set; }
    public string Machine { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal TrxActionId { get; set; }
    public string TrxActionDesc { get; set; }
    public string TrxActionEvent { get; set; }
    public string ReasonCode { get; set; }
    public string Resort { get; set; }
    public string ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodesAction>(entity =>
        {
            entity.HasKey(e => e.TrxActionId)
                .HasName("TRX_CODE_ACTION_PK");

            entity.ToTable("TRX$_CODES_ACTION");

            entity.HasIndex(e => new { e.InsertDate, e.ChainCode })
                .HasName("TC_ACTION_DATE_IDX");

            entity.Property(e => e.TrxActionId)
                .HasColumnName("TRX_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TrxActionDesc)
                .HasColumnName("TRX_ACTION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TrxActionEvent)
                .IsRequired()
                .HasColumnName("TRX_ACTION_EVENT")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
