namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpMappingCodes
{
    public ExpMappingCodes()
    {
        ExpMappingLinks = new HashSet<ExpMappingLinks>();
    }

    public decimal? ExpMappingId { get; set; }
    public string? MappingCode { get; set; }
    public string? CodeDesc { get; set; }
    public string? DataType { get; set; }
    public decimal? SeqNo { get; set; }
    public string? UseLovYn { get; set; }
    public string? LovName { get; set; }
    public string? RequiredYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ExpMappingTypes ExpMapping { get; set; }
    public virtual ICollection<ExpMappingLinks> ExpMappingLinks { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpMappingCodes>(entity =>
        {
            entity.HasKey(e => new { e.ExpMappingId, e.MappingCode })
                .HasName("EXP_MAPC_PK");

            entity.ToTable("EXP_MAPPING_CODES");

            entity.Property(e => e.ExpMappingId)
                .HasColumnName("EXP_MAPPING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MappingCode)
                .HasColumnName("MAPPING_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CodeDesc)
                .HasColumnName("CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LovName)
                .HasColumnName("LOV_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RequiredYn)
                .HasColumnName("REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UseLovYn)
                .HasColumnName("USE_LOV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(ExpMappingTypes)))
				entity.Ignore(e => e.ExpMapping);
			else
	            entity.HasOne(d => d.ExpMapping)
	                .WithMany(p => p.ExpMappingCodes)
	                .HasForeignKey(d => d.ExpMappingId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EXP_MAPC_EXP_MAPT_FK");
        
			if (!types.Contains(typeof(ExpMappingLinks)))
				entity.Ignore(e => e.ExpMappingLinks);
		});
	}
}
