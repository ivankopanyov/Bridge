namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ToolbarItems1
{
    public string Application { get; set; }
    public string WorkflowName { get; set; }
    public string MenuItem { get; set; }
    public string Name { get; set; }
    public string IconName { get; set; }
    public string CommandToRun { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ToolbarItems1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TOOLBAR_ITEMS");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("APPLICATION")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CommandToRun)
                .HasColumnName("COMMAND_TO_RUN")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IconName)
                .HasColumnName("ICON_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MenuItem)
                .IsRequired()
                .HasColumnName("MENU_ITEM")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WorkflowName)
                .IsRequired()
                .HasColumnName("WORKFLOW_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
