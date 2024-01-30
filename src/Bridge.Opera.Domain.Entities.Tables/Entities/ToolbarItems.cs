namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ToolbarItems
{
    public string? Application { get; set; }
    public string? WorkflowName { get; set; }
    public string? MenuItem { get; set; }
    public string? IconName { get; set; }
    public string? CommandToRun { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ToolbarItems>(entity =>
        {
            entity.HasKey(e => new { e.Application, e.WorkflowName, e.MenuItem })
                .HasName("TOOLBAR$_ITEMS_PK");

            entity.ToTable("TOOLBAR$_ITEMS");

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.WorkflowName)
                .HasColumnName("WORKFLOW_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MenuItem)
                .HasColumnName("MENU_ITEM")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CommandToRun)
                .HasColumnName("COMMAND_TO_RUN")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IconName)
                .HasColumnName("ICON_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
