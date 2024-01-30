namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BdeStage
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? Action { get; set; }
    public decimal? ActionId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BdeStage>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("BDE_STAGE_PK");

            entity.ToTable("BDE_STAGE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Action)
                .IsRequired()
                .HasColumnName("ACTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");
        });
	}
}
