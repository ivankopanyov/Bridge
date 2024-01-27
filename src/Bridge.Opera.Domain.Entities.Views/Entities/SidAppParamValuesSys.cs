namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidAppParamValuesSys
{
    public string ParameterName { get; set; }
    public string ParameterValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidAppParamValuesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_APP_PARAM_VALUES_SYS");

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
