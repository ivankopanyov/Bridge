namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MailTagsVw
{
    public decimal? SourceId { get; set; }
    public string? Tag { get; set; }
    public string? TableName { get; set; }
    public string? FieldName { get; set; }
    public string? DataType { get; set; }
    public string? TableDesc { get; set; }
    public string? FieldDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailTagsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MAIL_TAGS_VW");

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FieldDesc)
                .HasColumnName("FIELD_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableDesc)
                .HasColumnName("TABLE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Tag)
                .HasColumnName("TAG")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
