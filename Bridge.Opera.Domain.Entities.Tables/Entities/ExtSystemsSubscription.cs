namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExtSystemsSubscription
{
    public string SupSystem { get; set; }
    public string SupResort { get; set; }
    public string Subscriber { get; set; }

    public virtual ExtSystems SubscriberNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtSystemsSubscription>(entity =>
        {
            entity.HasKey(e => new { e.SupSystem, e.SupResort, e.Subscriber })
                .HasName("ESS_PK");

            entity.ToTable("EXT_SYSTEMS_SUBSCRIPTION");

            entity.HasIndex(e => e.Subscriber)
                .HasName("ESS_EXTSYS_FK_I");

            entity.Property(e => e.SupSystem)
                .HasColumnName("SUP_SYSTEM")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SupResort)
                .HasColumnName("SUP_RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Subscriber)
                .HasColumnName("SUBSCRIBER")
                .HasMaxLength(40)
                .IsUnicode(false);

			if (!types.Contains(typeof(ExtSystems)))
				entity.Ignore(e => e.SubscriberNavigation);
			else
	            entity.HasOne(d => d.SubscriberNavigation)
	                .WithMany(p => p.ExtSystemsSubscription)
	                .HasForeignKey(d => d.Subscriber)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ESS_EXTSYS_FK");
        });
	}
}
