namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SurveyByActivity
{
    public string Resort { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Owner { get; set; }
    public string SurveyName { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public decimal? Score { get; set; }
    public decimal ActId { get; set; }
    public decimal? AccId { get; set; }
    public string AccName { get; set; }
    public decimal? ConId { get; set; }
    public string ConName { get; set; }
    public decimal? BusblockId { get; set; }
    public string BusblockName { get; set; }
    public decimal? ActualRooms { get; set; }
    public decimal? ActualRevenue { get; set; }
    public decimal? ActualAvgRate { get; set; }
    public DateTime? BookBeginDate { get; set; }
    public DateTime? BookEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SurveyByActivity>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SURVEY_BY_ACTIVITY");

            entity.Property(e => e.AccId)
                .HasColumnName("ACC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccName)
                .HasColumnName("ACC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAvgRate)
                .HasColumnName("ACTUAL_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRooms)
                .HasColumnName("ACTUAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Answer)
                .HasColumnName("ANSWER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BookBeginDate)
                .HasColumnName("BOOK_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookEndDate)
                .HasColumnName("BOOK_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusblockName)
                .HasColumnName("BUSBLOCK_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ConId)
                .HasColumnName("CON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConName)
                .HasColumnName("CON_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Question)
                .HasColumnName("QUESTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Score)
                .HasColumnName("SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SurveyName)
                .HasColumnName("SURVEY_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
