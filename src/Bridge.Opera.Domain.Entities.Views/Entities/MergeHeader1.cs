namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MergeHeader1
{
    public decimal? MergeId { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MergeHeader1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MERGE_HEADER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.MergeId)
                .HasColumnName("MERGE_ID")
                .HasColumnType("NUMBER");
        });
	}
}
