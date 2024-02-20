namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidAppModuleDependencies
{
    public decimal? ModuleId { get; set; }
    public string? RModuleId { get; set; }
    public string? RType { get; set; }
    public string? CallParameters { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidAppModuleDependencies>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_APP_MODULE_DEPENDENCIES");

            entity.Property(e => e.CallParameters)
                .HasColumnName("CALL_PARAMETERS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RModuleId)
                .HasColumnName("R_MODULE_ID")
                .IsUnicode(false);

            entity.Property(e => e.RType)
                .IsRequired()
                .HasColumnName("R_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
