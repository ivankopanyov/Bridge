namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidScFieldOperatorSys
{
    public string? DefaultYn { get; set; }
    public string? FieldType { get; set; }
    public string? LovYn { get; set; }
    public string? Operator { get; set; }
    public string? OpDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidScFieldOperatorSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_SC$FIELD_OPERATOR_SYS");

            entity.Property(e => e.DefaultYn)
                .IsRequired()
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FieldType)
                .IsRequired()
                .HasColumnName("FIELD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LovYn)
                .IsRequired()
                .HasColumnName("LOV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OpDesc)
                .IsRequired()
                .HasColumnName("OP_DESC")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Operator)
                .IsRequired()
                .HasColumnName("OPERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
