namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileEntities
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? EntityCode { get; set; }
    public string? IncludedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileEntities>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_ENTITIES");

            entity.Property(e => e.EntityCode)
                .IsRequired()
                .HasColumnName("ENTITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IncludedYn)
                .HasColumnName("INCLUDED_YN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
