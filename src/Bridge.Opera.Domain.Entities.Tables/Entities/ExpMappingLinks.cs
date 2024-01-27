namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpMappingLinks
{
    public decimal ExpMappingId { get; set; }
    public string MappingCode { get; set; }
    public string LinkedCode { get; set; }
    public string ExportValue { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ExpMappingCodes ExpMappingCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpMappingLinks>(entity =>
        {
            entity.HasKey(e => new { e.ExpMappingId, e.MappingCode, e.LinkedCode })
                .HasName("EXP_MAPL_PK");

            entity.ToTable("EXP_MAPPING_LINKS");

            entity.Property(e => e.ExpMappingId)
                .HasColumnName("EXP_MAPPING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MappingCode)
                .HasColumnName("MAPPING_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LinkedCode)
                .HasColumnName("LINKED_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExportValue)
                .HasColumnName("EXPORT_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ExpMappingCodes)))
				entity.Ignore(e => e.ExpMappingCodes);
			else
	            entity.HasOne(d => d.ExpMappingCodes)
	                .WithMany(p => p.ExpMappingLinks)
	                .HasForeignKey(d => new { d.ExpMappingId, d.MappingCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EXP_MAPL_EXP_MAPC_FK");
        });
	}
}
