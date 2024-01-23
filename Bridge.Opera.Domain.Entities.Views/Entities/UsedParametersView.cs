namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UsedParametersView
{
    public string Resort { get; set; }
    public string ParameterName { get; set; }
    public string TrxCode { get; set; }
    public string Description { get; set; }
    public string ParameterGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UsedParametersView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USED_PARAMETERS_VIEW");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ParameterGroup)
                .HasColumnName("PARAMETER_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
