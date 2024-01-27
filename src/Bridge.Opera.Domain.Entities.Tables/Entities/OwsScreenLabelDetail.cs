namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsScreenLabelDetail
{
    public decimal Id { get; set; }
    public string ScreenLanguage { get; set; }
    public string ScreenDescription { get; set; }
    public string Tooltip { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string Host { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsScreenLabelDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.ScreenLanguage, e.Host })
                .HasName("OWS_SCREEN_LABEL_DETAIL_PK");

            entity.ToTable("OWS_SCREEN_LABEL_DETAIL");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScreenLanguage)
                .HasColumnName("SCREEN_LANGUAGE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Host)
                .HasColumnName("HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScreenDescription)
                .HasColumnName("SCREEN_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Tooltip)
                .HasColumnName("TOOLTIP")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
