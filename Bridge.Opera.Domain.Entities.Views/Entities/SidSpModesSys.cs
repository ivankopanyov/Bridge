namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidSpModesSys
{
    public string ModeValue { get; set; }
    public decimal? OrderBy { get; set; }
    public string Description { get; set; }
    public string UsedInForm { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidSpModesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_SP_MODES_SYS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ModeValue)
                .IsRequired()
                .HasColumnName("MODE_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UsedInForm)
                .IsRequired()
                .HasColumnName("USED_IN_FORM")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
