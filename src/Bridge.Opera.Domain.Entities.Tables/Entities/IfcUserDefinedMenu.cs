namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcUserDefinedMenu
{
    public string? Resort { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public decimal? UserdefId { get; set; }
    public decimal? ParentId { get; set; }
    public string? Description { get; set; }
    public string? UserInputYn { get; set; }
    public string? PreConfText { get; set; }
    public string? InputDataType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcUserDefinedMenu>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_USER_DEFINED_MENU");

            entity.HasIndex(e => new { e.Resort, e.IfcCtrlId, e.UserdefId })
                .HasName("IFC_UD_MENU_RIU_IND");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InputDataType)
                .HasColumnName("INPUT_DATA_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ParentId)
                .HasColumnName("PARENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreConfText)
                .HasColumnName("PRE_CONF_TEXT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UserInputYn)
                .HasColumnName("USER_INPUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UserdefId)
                .HasColumnName("USERDEF_ID")
                .HasColumnType("NUMBER");
        });
	}
}
