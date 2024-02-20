namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CommissionProcessAction
{
    public string? Resort { get; set; }
    public decimal? ActionId { get; set; }
    public DateTime? ActionDate { get; set; }
    public string? ActionType { get; set; }
    public string? ActionDescription { get; set; }
    public string? PrevValue { get; set; }
    public string? NewValue { get; set; }
    public string? Machine { get; set; }
    public decimal? NameId { get; set; }
    public string? Terminal { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? RunDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CommissionProcessAction>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ActionId })
                .HasName("COMMISSION_PROCESS_ACTION_PK");

            entity.ToTable("COMMISSION_PROCESS_ACTION");

            entity.HasIndex(e => new { e.InsertDate, e.ChainCode })
                .HasName("COMMISSION_PROCESS_ACTION_IDX1");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("COMMISSION_PROCESS_ACTION_IDX2");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDate)
                .HasColumnName("ACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

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

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrevValue)
                .HasColumnName("PREV_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RunDate)
                .HasColumnName("RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
