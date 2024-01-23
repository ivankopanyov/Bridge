namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PopupMessages
{
    public string Resort { get; set; }
    public string MessageCode { get; set; }
    public string Module { get; set; }
    public string ModuleMode { get; set; }
    public string Description { get; set; }
    public string HideYn { get; set; }
    public string DefaultValue { get; set; }
    public string MessageType { get; set; }
    public string LovClause { get; set; }
    public string MessageDescription { get; set; }
    public string UsedInApp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PopupMessages>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.MessageCode, e.Module, e.ModuleMode })
                .HasName("POP_PK");

            entity.ToTable("POPUP_MESSAGES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MessageCode)
                .HasColumnName("MESSAGE_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModuleMode)
                .HasColumnName("MODULE_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HideYn)
                .IsRequired()
                .HasColumnName("HIDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LovClause)
                .HasColumnName("LOV_CLAUSE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MessageDescription)
                .HasColumnName("MESSAGE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .IsRequired()
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
