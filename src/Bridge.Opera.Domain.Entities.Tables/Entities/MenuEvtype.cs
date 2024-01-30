namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MenuEvtype
{
    public decimal? MenuId { get; set; }
    public string? EventType { get; set; }

    public virtual GemMenu Menu { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MenuEvtype>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.EventType })
                .HasName("MEN_ET_PK");

            entity.ToTable("MENU$EVTYPE");

            entity.HasIndex(e => e.EventType)
                .HasName("MEN_EVTYPE_IDX");

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemMenu)))
				entity.Ignore(e => e.Menu);
			else
	            entity.HasOne(d => d.Menu)
	                .WithMany(p => p.MenuEvtype)
	                .HasForeignKey(d => d.MenuId)
	                .HasConstraintName("MEN_ET_MEN_FK");
        });
	}
}
