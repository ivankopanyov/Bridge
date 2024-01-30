namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ChnlCnvParamValues
{
    public string? Resort { get; set; }
    public string? GdsHost { get; set; }
    public string? ParameterName { get; set; }
    public string? ParameterValue { get; set; }

    public virtual ChnlCnvParamNames ParameterNameNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ChnlCnvParamValues>(entity =>
        {
            entity.HasKey(e => new { e.ParameterName, e.GdsHost, e.Resort })
                .HasName("CHNL_CNV_PARAM_VALUES_PK");

            entity.ToTable("CHNL_CNV_PARAM_VALUES");

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ChnlCnvParamNames)))
				entity.Ignore(e => e.ParameterNameNavigation);
			else
	            entity.HasOne(d => d.ParameterNameNavigation)
	                .WithMany(p => p.ChnlCnvParamValues)
	                .HasForeignKey(d => d.ParameterName)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CHNL_CNV_PARAM_VALUES_FK1");
        });
	}
}
