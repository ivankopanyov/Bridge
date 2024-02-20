namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Feature
{
    public string? Feature1 { get; set; }
    public string? Description { get; set; }
    public string? Type { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? OrderBy { get; set; }
    public string? IconName { get; set; }
    public string? Filename { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? CrsMessageYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Feature>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FEATURE");

            entity.Property(e => e.CrsMessageYn)
                .HasColumnName("CRS_MESSAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Feature1)
                .IsRequired()
                .HasColumnName("FEATURE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Filename)
                .HasColumnName("FILENAME")
                .HasColumnType("CHAR(2000)");

            entity.Property(e => e.IconName)
                .HasColumnName("ICON_NAME")
                .HasColumnType("CHAR(2000)");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
