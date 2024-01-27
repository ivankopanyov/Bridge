namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsConvTimezones
{
    public string ResortTimezone { get; set; }
    public string GdsTimezone { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsConvTimezones>(entity =>
        {
            entity.HasKey(e => e.ResortTimezone)
                .HasName("GDS_CONV_TIMEZONE_PK");

            entity.ToTable("GDS_CONV_TIMEZONES");

            entity.Property(e => e.ResortTimezone)
                .HasColumnName("RESORT_TIMEZONE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GdsTimezone)
                .IsRequired()
                .HasColumnName("GDS_TIMEZONE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
