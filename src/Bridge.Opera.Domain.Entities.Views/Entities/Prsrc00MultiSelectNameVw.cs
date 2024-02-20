namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Prsrc00MultiSelectNameVw
{
    public decimal? NameId { get; set; }
    public string? SelectedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Prsrc00MultiSelectNameVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PRSRC00_MULTI_SELECT_NAME_VW");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SelectedYn)
                .HasColumnName("SELECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
