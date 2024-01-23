namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ConfirmationFormatElements
{
    public string FormatType { get; set; }
    public string FormatElement { get; set; }
    public byte? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConfirmationFormatElements>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CONFIRMATION_FORMAT_ELEMENTS");

            entity.Property(e => e.FormatElement)
                .IsRequired()
                .HasColumnName("FORMAT_ELEMENT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FormatType)
                .IsRequired()
                .HasColumnName("FORMAT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy).HasColumnName("ORDER_BY");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
