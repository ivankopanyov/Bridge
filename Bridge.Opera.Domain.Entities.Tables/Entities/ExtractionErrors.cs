namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExtractionErrors
{
    public string FormName { get; set; }
    public string ErrorDescription { get; set; }
    public string Comments { get; set; }
    public DateTime? CreatedDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtractionErrors>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EXTRACTION_ERRORS");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CREATED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ErrorDescription)
                .HasColumnName("ERROR_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
