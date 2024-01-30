namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RmonParameters
{
    public string? ParameterName { get; set; }
    public string? ParameterPriority { get; set; }
    public string? ParameterDisplay { get; set; }
    public string? ParameterValue { get; set; }
    public decimal? ParameterValueFrom { get; set; }
    public decimal? ParameterValueTo { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RmonParameters>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RMON_PARAMETERS");

            entity.HasIndex(e => e.ParameterName)
                .HasName("RMON_PRM_NAME");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParameterDisplay)
                .IsRequired()
                .HasColumnName("PARAMETER_DISPLAY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterPriority)
                .HasColumnName("PARAMETER_PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValueFrom)
                .HasColumnName("PARAMETER_VALUE_FROM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParameterValueTo)
                .HasColumnName("PARAMETER_VALUE_TO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
