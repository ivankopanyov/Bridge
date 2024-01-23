namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomCombo1
{
    public string Resort { get; set; }
    public string ComboRoom { get; set; }
    public string ComboElement { get; set; }
    public decimal? PercentUtilized { get; set; }
    public decimal? AreaUtilized { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomCombo1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_COMBO");

            entity.Property(e => e.AreaUtilized)
                .HasColumnName("AREA_UTILIZED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComboElement)
                .IsRequired()
                .HasColumnName("COMBO_ELEMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComboRoom)
                .IsRequired()
                .HasColumnName("COMBO_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PercentUtilized)
                .HasColumnName("PERCENT_UTILIZED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
