namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScFieldOperator
{
    public string FieldType { get; set; }
    public string LovYn { get; set; }
    public string Operator { get; set; }
    public string OpDesc { get; set; }
    public string DefaultYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScFieldOperator>(entity =>
        {
            entity.HasKey(e => new { e.FieldType, e.Operator, e.LovYn })
                .HasName("SFO_PK");

            entity.ToTable("SC$FIELD_OPERATOR");

            entity.Property(e => e.FieldType)
                .HasColumnName("FIELD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Operator)
                .HasColumnName("OPERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LovYn)
                .HasColumnName("LOV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .IsRequired()
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OpDesc)
                .IsRequired()
                .HasColumnName("OP_DESC")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
