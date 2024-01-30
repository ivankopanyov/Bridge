namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActionTypeMandWhere
{
    public string? ExtSystemCode { get; set; }
    public string? Module { get; set; }
    public string? ActionType { get; set; }
    public string? MandatoryWhereClause { get; set; }

    public virtual ActionType ActionTypeNavigation { get; set; }
    public virtual ExtSystems ExtSystemCodeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActionTypeMandWhere>(entity =>
        {
            entity.HasKey(e => new { e.ExtSystemCode, e.Module, e.ActionType })
                .HasName("ACTION_TYPE_MAND_WHERE_PK");

            entity.ToTable("ACTION_TYPE_MAND_WHERE");

            entity.HasIndex(e => new { e.Module, e.ActionType })
                .HasName("ACTION_TYPE_MAND_WHERE_AT_FKI");

            entity.Property(e => e.ExtSystemCode)
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MandatoryWhereClause)
                .HasColumnName("MANDATORY_WHERE_CLAUSE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ExtSystems)))
				entity.Ignore(e => e.ExtSystemCodeNavigation);
			else
	            entity.HasOne(d => d.ExtSystemCodeNavigation)
	                .WithMany(p => p.ActionTypeMandWhere)
	                .HasForeignKey(d => d.ExtSystemCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ACTION_TYPE_MAND_WHERE_ES_FK");

			if (!types.Contains(typeof(ActionType)))
				entity.Ignore(e => e.ActionTypeNavigation);
			else
	            entity.HasOne(d => d.ActionTypeNavigation)
	                .WithMany(p => p.ActionTypeMandWhere)
	                .HasForeignKey(d => new { d.Module, d.ActionType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ACTION_TYPE_MAND_WHERE_AT_FK");
        });
	}
}
