namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RiQuestions
{
    public string Resort { get; set; }
    public string QuestionType { get; set; }
    public decimal RiQuestionsId { get; set; }
    public string RiQuestionsDescription { get; set; }
    public decimal? RiQuestionsSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RiQuestions>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RI_QUESTIONS");

            entity.Property(e => e.QuestionType)
                .IsRequired()
                .HasColumnName("QUESTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiQuestionsDescription)
                .IsRequired()
                .HasColumnName("RI_QUESTIONS_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RiQuestionsId)
                .HasColumnName("RI_QUESTIONS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiQuestionsSeq)
                .HasColumnName("RI_QUESTIONS_SEQ")
                .HasColumnType("NUMBER");
        });
	}
}
