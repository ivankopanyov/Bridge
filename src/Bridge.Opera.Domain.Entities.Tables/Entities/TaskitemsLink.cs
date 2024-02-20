namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TaskitemsLink
{
    public decimal? TiId { get; set; }
    public string? LinkType { get; set; }
    public decimal? LinkId { get; set; }

    public virtual Taskitems Ti { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskitemsLink>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TASKITEMS_LINK");

            entity.HasIndex(e => e.TiId)
                .HasName("TASKITEMLINK_FK1_I");

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkType)
                .IsRequired()
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TiId)
                .HasColumnName("TI_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Taskitems)))
				entity.Ignore(e => e.Ti);
			else
	            entity.HasOne(d => d.Ti)
	                .WithMany()
	                .HasPrincipalKey(p => p.TaskitemNumber)
	                .HasForeignKey(d => d.TiId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TASKITEMLINK_FK1");
        });
	}
}
