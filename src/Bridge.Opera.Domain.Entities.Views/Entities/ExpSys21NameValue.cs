namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21NameValue
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NameValueType { get; set; }
    public decimal? NameValueId { get; set; }
    public string NameElement { get; set; }
    public string ValueElement { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21NameValue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_NAME_VALUE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameElement)
                .HasColumnName("NAME_ELEMENT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameValueId)
                .HasColumnName("NAME_VALUE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameValueType)
                .HasColumnName("NAME_VALUE_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValueElement)
                .HasColumnName("VALUE_ELEMENT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
