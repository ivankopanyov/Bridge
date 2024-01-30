namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ColourDetails1
{
    public decimal? ColourId { get; set; }
    public string? OpenYn { get; set; }
    public string? TableName { get; set; }
    public string? FieldName { get; set; }
    public string? Operator { get; set; }
    public string? Value { get; set; }
    public string? CloseYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Connector { get; set; }
    public string? FieldType { get; set; }
    public string? Colour { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ColourDetails1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COLOUR_DETAILS");

            entity.Property(e => e.CloseYn)
                .HasColumnName("CLOSE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Colour)
                .HasColumnName("COLOUR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ColourId)
                .HasColumnName("COLOUR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Connector)
                .HasColumnName("CONNECTOR")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldType)
                .HasColumnName("FIELD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OpenYn)
                .HasColumnName("OPEN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Operator)
                .HasColumnName("OPERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
