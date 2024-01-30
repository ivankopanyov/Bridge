namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidQbEntitySys
{
    public string? EntityName { get; set; }
    public string? EntityLabel { get; set; }
    public string? BaseTable { get; set; }
    public string? EntityAlias { get; set; }
    public string? EntityDesc { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidQbEntitySys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_QB_ENTITY_SYS");

            entity.Property(e => e.BaseTable)
                .HasColumnName("BASE_TABLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EntityAlias)
                .HasColumnName("ENTITY_ALIAS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EntityDesc)
                .HasColumnName("ENTITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.EntityLabel)
                .HasColumnName("ENTITY_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EntityName)
                .IsRequired()
                .HasColumnName("ENTITY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
