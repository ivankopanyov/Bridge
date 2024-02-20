namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AccConBookHasattachments
{
    public string? Resort { get; set; }
    public decimal? LinkId { get; set; }
    public string? GlobalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AccConBookHasattachments>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ACC_CON_BOOK_HASATTACHMENTS");

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
