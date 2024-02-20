namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOwsScreenLabelSys
{
    public decimal? Id { get; set; }
    public string? ScreenName { get; set; }
    public string? ScreenId { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOwsScreenLabelSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OWS_SCREEN_LABEL_SYS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScreenId)
                .IsRequired()
                .HasColumnName("SCREEN_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ScreenName)
                .IsRequired()
                .HasColumnName("SCREEN_NAME")
                .HasMaxLength(50)
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
