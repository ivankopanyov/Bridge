namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RepProdChSummary
{
    public decimal? BbId { get; set; }
    public string? Salesmgr { get; set; }
    public string? Status { get; set; }
    public decimal? Rmnghts { get; set; }
    public decimal? RmnghtsChange { get; set; }
    public decimal? Rmrevenue { get; set; }
    public decimal? RmrevenueChange { get; set; }
    public string? Resort { get; set; }
    public string? StatuschangeYn { get; set; }
    public DateTime? ChangeDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepProdChSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("REP_PROD_CH_SUMMARY");

            entity.Property(e => e.BbId)
                .HasColumnName("BB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Rmnghts)
                .HasColumnName("RMNGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmnghtsChange)
                .HasColumnName("RMNGHTS_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rmrevenue)
                .HasColumnName("RMREVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmrevenueChange)
                .HasColumnName("RMREVENUE_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Salesmgr)
                .HasColumnName("SALESMGR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatuschangeYn)
                .HasColumnName("STATUSCHANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
