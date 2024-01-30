namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMailOperatorSys
{
    public decimal? OperatorId { get; set; }
    public string? DataType { get; set; }
    public string? Description { get; set; }
    public string? VirtualYn { get; set; }
    public string? DefaultYn { get; set; }
    public string? DerivedYn { get; set; }
    public decimal? SourceId { get; set; }
    public string? FieldName { get; set; }
    public string? OperatorCode { get; set; }
    public string? InternalYn { get; set; }
    public string? UseNullYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMailOperatorSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MAIL_OPERATOR_SYS");

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DerivedYn)
                .HasColumnName("DERIVED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OperatorCode)
                .HasColumnName("OPERATOR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OperatorId)
                .HasColumnName("OPERATOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UseNullYn)
                .HasColumnName("USE_NULL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VirtualYn)
                .HasColumnName("VIRTUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
