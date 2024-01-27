namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RevenueGroupsTranslation
{
    public string ChainCode { get; set; }
    public string RevGroup { get; set; }
    public string Field { get; set; }
    public string Language { get; set; }
    public string Description { get; set; }

    public virtual RevenueGroups RevenueGroups { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RevenueGroupsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RevGroup, e.Field, e.Language })
                .HasName("REVGT_PK");

            entity.ToTable("REVENUE$GROUPS_TRANSLATION");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Field)
                .HasColumnName("FIELD")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(RevenueGroups)))
				entity.Ignore(e => e.RevenueGroups);
			else
	            entity.HasOne(d => d.RevenueGroups)
	                .WithMany(p => p.RevenueGroupsTranslation)
	                .HasForeignKey(d => new { d.ChainCode, d.RevGroup })
	                .HasConstraintName("REVGT_REVG_FK");
        });
	}
}
