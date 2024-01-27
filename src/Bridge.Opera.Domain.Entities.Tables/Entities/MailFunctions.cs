namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailFunctions
{
    public decimal FunctionId { get; set; }
    public string Description { get; set; }
    public string DataType { get; set; }
    public decimal SourceId { get; set; }
    public string FunctionCode { get; set; }
    public string HasParameterYn { get; set; }
    public string ParameterDataType { get; set; }
    public string DefaultYn { get; set; }
    public string Realisation { get; set; }
    public string Visualisation { get; set; }
    public string ExecuteYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailFunctions>(entity =>
        {
            entity.HasKey(e => e.FunctionId)
                .HasName("MAIL_FUNCTIONS_PK");

            entity.ToTable("MAIL_FUNCTIONS");

            entity.HasIndex(e => new { e.FunctionCode, e.DataType, e.SourceId })
                .HasName("MAIL_FUNCTIONS_UK")
                .IsUnique();

            entity.Property(e => e.FunctionId)
                .HasColumnName("FUNCTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .IsRequired()
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExecuteYn)
                .IsRequired()
                .HasColumnName("EXECUTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FunctionCode)
                .IsRequired()
                .HasColumnName("FUNCTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HasParameterYn)
                .IsRequired()
                .HasColumnName("HAS_PARAMETER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ParameterDataType)
                .IsRequired()
                .HasColumnName("PARAMETER_DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Realisation)
                .IsRequired()
                .HasColumnName("REALISATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Visualisation)
                .IsRequired()
                .HasColumnName("VISUALISATION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
