namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ActionTypSubWhereBaseView
{
    public decimal? ClauseId { get; set; }
    public string? ExtSystemCode { get; set; }
    public string? Module { get; set; }
    public string? ActionType { get; set; }
    public string? DataElementState { get; set; }
    public string? DataElement { get; set; }
    public string? Operator { get; set; }
    public string? DeValue { get; set; }
    public string? Andor { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActionTypSubWhereBaseView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ACTION_TYP_SUB_WHERE_BASE_VIEW");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Andor)
                .HasColumnName("ANDOR")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.ClauseId)
                .HasColumnName("CLAUSE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataElement)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DataElementState)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT_STATE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeValue)
                .HasColumnName("DE_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExtSystemCode)
                .IsRequired()
                .HasColumnName("EXT_SYSTEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Operator)
                .IsRequired()
                .HasColumnName("OPERATOR")
                .HasMaxLength(240)
                .IsUnicode(false);
        });
	}
}
