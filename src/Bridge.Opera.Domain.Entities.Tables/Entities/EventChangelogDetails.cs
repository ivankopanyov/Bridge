namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventChangelogDetails
{
    public decimal? ChangeId { get; set; }
    public string? Fieldname { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }

    public virtual EventChangelog Change { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventChangelogDetails>(entity =>
        {
            entity.HasKey(e => new { e.ChangeId, e.Fieldname })
                .HasName("EVLOGD_PK");

            entity.ToTable("EVENT$CHANGELOG_DETAILS");

            entity.Property(e => e.ChangeId)
                .HasColumnName("CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Fieldname)
                .HasColumnName("FIELDNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(EventChangelog)))
				entity.Ignore(e => e.Change);
			else
	            entity.HasOne(d => d.Change)
	                .WithMany(p => p.EventChangelogDetails)
	                .HasForeignKey(d => d.ChangeId)
	                .HasConstraintName("EVLOGD_EVLOG_FK");
        });
	}
}
