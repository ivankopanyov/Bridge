namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortAccess
{
    public string? Resort { get; set; }
    public decimal? UserId { get; set; }
    public string? Responsibility { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortAccess>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Responsibility, e.UserId })
                .HasName("RESORT_ACCESS_PK");

            entity.ToTable("RESORT_ACCESS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Responsibility)
                .HasColumnName("RESPONSIBILITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ResortAccess)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESORT_FK14");
        });
	}
}
