namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RegCardListView
{
    public string RegCard { get; set; }
    public string RegCardDesc { get; set; }
    public decimal RegCardId { get; set; }
    public string DefaultModuleType { get; set; }
    public string ModuleName { get; set; }
    public decimal? Copies { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RegCardListView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REG_CARD_LIST_VIEW");

            entity.Property(e => e.Copies)
                .HasColumnName("COPIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultModuleType)
                .HasColumnName("DEFAULT_MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RegCard)
                .IsRequired()
                .HasColumnName("REG_CARD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RegCardDesc)
                .HasColumnName("REG_CARD_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.RegCardId)
                .HasColumnName("REG_CARD_ID")
                .HasColumnType("NUMBER");
        });
	}
}
