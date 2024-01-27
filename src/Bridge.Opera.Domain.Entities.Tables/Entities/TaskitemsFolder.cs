namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TaskitemsFolder
{
    public TaskitemsFolder()
    {
        Taskitems = new HashSet<Taskitems>();
    }

    public string Resort { get; set; }
    public string CategoryCode { get; set; }
    public string FolderName { get; set; }
    public string Description { get; set; }

    public virtual ICollection<Taskitems> Taskitems { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskitemsFolder>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.FolderName })
                .HasName("TF_PK");

            entity.ToTable("TASKITEMS_FOLDER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolderName)
                .HasColumnName("FOLDER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CategoryCode)
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(Taskitems)))
				entity.Ignore(e => e.Taskitems);
		});
	}
}
