namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntSidParameters
{
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public string ParameterGroup { get; set; }
    public string ParameterName { get; set; }
    public string ParameterValue { get; set; }
    public string Description { get; set; }
    public string LovValues { get; set; }
    public string DisplayYn { get; set; }
    public string UpperCase { get; set; }
    public string DisplayName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntSidParameters>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_SID_PARAMETERS");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort, e.ParameterName })
                .HasName("INT_SID_PARM_IDX1")
                .IsUnique();

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
                .HasColumnType("CHAR(1)")
                .HasDefaultValueSql("'Y'");

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
                .HasColumnType("CHAR(1)")
                .HasDefaultValueSql("'Y'");
        });
	}
}
