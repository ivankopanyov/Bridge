namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BqtChkBbInfo
{
    public decimal? Bookid { get; set; }
    public string? Resort { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Bbstatus { get; set; }
    public string? Catstatus { get; set; }
    public string? Status { get; set; }
    public string? Description { get; set; }
    public string? Bbtype { get; set; }
    public decimal? Company { get; set; }
    public decimal? ReportId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BqtChkBbInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BQT_CHK_BB_INFO");

            entity.Property(e => e.Bbstatus)
                .HasColumnName("BBSTATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Bbtype)
                .HasColumnName("BBTYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Bookid)
                .HasColumnName("BOOKID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Catstatus)
                .HasColumnName("CATSTATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
