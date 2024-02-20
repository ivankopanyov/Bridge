namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcControllerRegSettings
{
    public decimal? Id { get; set; }
    public string? Machine { get; set; }
    public string? CntrlRegSetting { get; set; }
    public string? Data { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcControllerRegSettings>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_CONTROLLER_REG_SETTINGS");

            entity.Property(e => e.CntrlRegSetting)
                .HasColumnName("CNTRL_REG_SETTING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Data)
                .HasColumnName("DATA")
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
