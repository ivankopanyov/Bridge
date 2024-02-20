namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidIntSidParametersSys
{
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? ParameterGroup { get; set; }
    public string? ParameterName { get; set; }
    public string? ParameterValue { get; set; }
    public string? Description { get; set; }
    public string? LovValues { get; set; }
    public string? DisplayYn { get; set; }
    public string? UpperCase { get; set; }
    public string? DisplayName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidIntSidParametersSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INT_SID_PARAMETERS_SYS");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .IsRequired()
                .HasColumnName("DISPLAY_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LovValues)
                .HasColumnName("LOV_VALUES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ParameterGroup)
                .IsRequired()
                .HasColumnName("PARAMETER_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpperCase)
                .IsRequired()
                .HasColumnName("UPPER_CASE")
                .HasColumnType("CHAR(1)");
        });
	}
}
