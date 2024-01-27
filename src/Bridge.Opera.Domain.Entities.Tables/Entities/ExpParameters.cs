namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpParameters
{
    public decimal ExpFileId { get; set; }
    public string ParamCode { get; set; }
    public string ParamDesc { get; set; }
    public string ParamValue { get; set; }

    public virtual ExpFileHdr ExpFile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpParameters>(entity =>
        {
            entity.HasKey(e => new { e.ExpFileId, e.ParamCode })
                .HasName("EXP_PARAMETERS_PK");

            entity.ToTable("EXP_PARAMETERS");

            entity.Property(e => e.ExpFileId)
                .HasColumnName("EXP_FILE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParamCode)
                .HasColumnName("PARAM_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParamDesc)
                .HasColumnName("PARAM_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParamValue)
                .HasColumnName("PARAM_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ExpFileHdr)))
				entity.Ignore(e => e.ExpFile);
			else
	            entity.HasOne(d => d.ExpFile)
	                .WithMany(p => p.ExpParameters)
	                .HasForeignKey(d => d.ExpFileId)
	                .HasConstraintName("EXP_PARAMETERS_FK");
        });
	}
}
