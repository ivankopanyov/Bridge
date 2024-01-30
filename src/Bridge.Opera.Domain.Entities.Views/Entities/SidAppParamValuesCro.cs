namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidAppParamValuesCro
{
    public string? Resort { get; set; }
    public string? ParameterName { get; set; }
    public string? ParameterValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidAppParamValuesCro>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_APP_PARAM_VALUES_CRO");

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
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
