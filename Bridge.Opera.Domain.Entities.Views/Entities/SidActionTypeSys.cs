namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidActionTypeSys
{
    public string Module { get; set; }
    public string ActionType { get; set; }
    public string UserLogPresentation { get; set; }
    public string DeImpactWhenYn { get; set; }
    public string InheritDeFromModule { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidActionTypeSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ACTION_TYPE_SYS");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DeImpactWhenYn)
                .HasColumnName("DE_IMPACT_WHEN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InheritDeFromModule)
                .HasColumnName("INHERIT_DE_FROM_MODULE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UserLogPresentation)
                .IsRequired()
                .HasColumnName("USER_LOG_PRESENTATION")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
