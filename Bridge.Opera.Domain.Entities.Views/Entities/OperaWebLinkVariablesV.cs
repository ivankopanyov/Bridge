namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaWebLinkVariablesV
{
    public string VariableName { get; set; }
    public string VariableDescription { get; set; }
    public string ScreenAccess { get; set; }
    public string WebLinkVariable { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaWebLinkVariablesV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_WEB_LINK_VARIABLES_V");

            entity.Property(e => e.ScreenAccess)
                .HasColumnName("SCREEN_ACCESS")
                .HasColumnType("CHAR(4)");

            entity.Property(e => e.VariableDescription)
                .HasColumnName("VARIABLE_DESCRIPTION")
                .HasMaxLength(31)
                .IsUnicode(false);

            entity.Property(e => e.VariableName)
                .HasColumnName("VARIABLE_NAME")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.WebLinkVariable)
                .HasColumnName("WEB_LINK_VARIABLE")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
