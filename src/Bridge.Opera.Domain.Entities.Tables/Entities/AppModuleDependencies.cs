namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppModuleDependencies
{
    public decimal ModuleId { get; set; }
    public decimal RModuleId { get; set; }
    public string RType { get; set; }
    public string CallParameters { get; set; }

    public virtual AppModules Module { get; set; }
    public virtual AppModules RModule { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppModuleDependencies>(entity =>
        {
            entity.HasKey(e => new { e.ModuleId, e.RModuleId, e.RType })
                .HasName("APP_MODULE_DEP_PK");

            entity.ToTable("APP_MODULE_DEPENDENCIES");

            entity.HasIndex(e => e.RModuleId)
                .HasName("MODULE_CHILD_FK_I");

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RModuleId)
                .HasColumnName("R_MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RType)
                .HasColumnName("R_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CallParameters)
                .HasColumnName("CALL_PARAMETERS")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(AppModules)))
				entity.Ignore(e => e.Module);
			else
	            entity.HasOne(d => d.Module)
	                .WithMany(p => p.AppModuleDependenciesModule)
	                .HasForeignKey(d => d.ModuleId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MODULE_MASTER_FK");

			if (!types.Contains(typeof(AppModules)))
				entity.Ignore(e => e.RModule);
			else
	            entity.HasOne(d => d.RModule)
	                .WithMany(p => p.AppModuleDependenciesRModule)
	                .HasForeignKey(d => d.RModuleId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MODULE_CHILD_FK");
        });
	}
}
