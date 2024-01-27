namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ApplicationModules
{
    public string Application { get; set; }
    public string FormToRun { get; set; }
    public string AppUserColumn { get; set; }
    public string Description { get; set; }
    public string Runningapp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ApplicationModules>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("APPLICATION_MODULES");

            entity.Property(e => e.AppUserColumn)
                .HasColumnName("APP_USER_COLUMN")
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(37)
                .IsUnicode(false);

            entity.Property(e => e.FormToRun)
                .HasColumnName("FORM_TO_RUN")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.Runningapp)
                .HasColumnName("RUNNINGAPP")
                .HasMaxLength(3)
                .IsUnicode(false);
        });
	}
}
