namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ShiftReports
{
    public decimal? ShiftGroupId { get; set; }
    public decimal? AttachedModuleId { get; set; }
    public string? CanDeleteYn { get; set; }

    public virtual AppModules AttachedModule { get; set; }
    public virtual AppModules ShiftGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ShiftReports>(entity =>
        {
            entity.HasKey(e => new { e.ShiftGroupId, e.AttachedModuleId })
                .HasName("SHIFT_REPORTS_PK");

            entity.ToTable("SHIFT_REPORTS");

            entity.HasIndex(e => e.AttachedModuleId)
                .HasName("ATTACHED_MODULE_ID_FKI");

            entity.Property(e => e.ShiftGroupId)
                .HasColumnName("SHIFT_GROUP_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AttachedModuleId)
                .HasColumnName("ATTACHED_MODULE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(AppModules)))
				entity.Ignore(e => e.AttachedModule);
			else
	            entity.HasOne(d => d.AttachedModule)
	                .WithMany(p => p.ShiftReportsAttachedModule)
	                .HasForeignKey(d => d.AttachedModuleId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ATTACHED_MODULE_ID_FK");

			if (!types.Contains(typeof(AppModules)))
				entity.Ignore(e => e.ShiftGroup);
			else
	            entity.HasOne(d => d.ShiftGroup)
	                .WithMany(p => p.ShiftReportsShiftGroup)
	                .HasForeignKey(d => d.ShiftGroupId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("SHIFT_GROUP_ID_FK");
        });
	}
}
