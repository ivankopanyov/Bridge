namespace Bridge.Opera.Domain.Entities.Tables;

public partial class QuestionTypes
{
    public string? Resort { get; set; }
    public string? TypeCode { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QuestionTypes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TypeCode })
                .HasName("QMS_QT_PK");

            entity.ToTable("QUESTION_TYPES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeCode)
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
