namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsFormValidationMessages
{
    public decimal MessageId { get; set; }
    public string MessageText { get; set; }
    public string MessageDesc { get; set; }
    public string ValidationType { get; set; }
    public string LanguageCode { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsFormValidationMessages>(entity =>
        {
            entity.HasKey(e => e.MessageId)
                .HasName("OWS_FORM_VALIDATION_MSGS_PK");

            entity.ToTable("OWS_FORM_VALIDATION_MESSAGES");

            entity.HasIndex(e => new { e.ValidationType, e.LanguageCode })
                .HasName("OWS_FORM_VAL_MSGS_IDX1")
                .IsUnique();

            entity.Property(e => e.MessageId)
                .HasColumnName("MESSAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.MessageDesc)
                .HasColumnName("MESSAGE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MessageText)
                .IsRequired()
                .HasColumnName("MESSAGE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidationType)
                .IsRequired()
                .HasColumnName("VALIDATION_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
