namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidShiftReports
{
    public decimal? ShiftGroupId { get; set; }
    public decimal? AttachedModuleId { get; set; }
    public string CanDeleteYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidShiftReports>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_SHIFT_REPORTS");

            entity.Property(e => e.AttachedModuleId)
                .HasColumnName("ATTACHED_MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ShiftGroupId)
                .HasColumnName("SHIFT_GROUP_ID")
                .HasColumnType("NUMBER");
        });
	}
}
