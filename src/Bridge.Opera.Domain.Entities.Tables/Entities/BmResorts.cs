namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmResorts
{
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }

    public virtual BmAccounts Name { get; set; }
    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmResorts>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("BMP_PK");

            entity.ToTable("BM_RESORTS");

            entity.HasIndex(e => e.NameId)
                .HasName("MBP_NAME_ID");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(BmAccounts)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.BmResorts)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BMP_BMA_FK");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithOne(p => p.BmResorts)
	                .HasForeignKey<BmResorts>(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BMP_RET_FK");
        });
	}
}
