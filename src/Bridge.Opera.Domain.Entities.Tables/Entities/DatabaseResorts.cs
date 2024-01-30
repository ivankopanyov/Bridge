namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DatabaseResorts
{
    public string? DatabaseId { get; set; }
    public string? Resort { get; set; }

    public virtual Databases Database { get; set; }
    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DatabaseResorts>(entity =>
        {
            entity.HasKey(e => new { e.DatabaseId, e.Resort })
                .HasName("DATABASE_RESORTS_PK");

            entity.ToTable("DATABASE_RESORTS");

            entity.HasIndex(e => e.Resort)
                .HasName("DATABASE_RESORTS_IND1");

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(Databases)))
				entity.Ignore(e => e.Database);
			else
	            entity.HasOne(d => d.Database)
	                .WithMany(p => p.DatabaseResorts)
	                .HasForeignKey(d => d.DatabaseId)
	                .HasConstraintName("DATABASE_RESORTS_FK");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.DatabaseResorts)
	                .HasForeignKey(d => d.Resort)
	                .HasConstraintName("DATABASE_RESO_RESORT_FK");
        });
	}
}
