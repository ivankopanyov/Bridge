namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsFcGroupDtls
{
    public string Resort { get; set; }
    public string CodeType { get; set; }
    public string GroupCode { get; set; }
    public string AttributeCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual OrmsFcGroupCodes OrmsFcGroupCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsFcGroupDtls>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CodeType, e.GroupCode, e.AttributeCode })
                .HasName("ORMS_FC_GRP_DTLS_PK");

            entity.ToTable("ORMS_FC_GROUP_DTLS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CodeType)
                .HasColumnName("CODE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttributeCode)
                .HasColumnName("ATTRIBUTE_CODE")
                .HasMaxLength(80)
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

			if (!types.Contains(typeof(OrmsFcGroupCodes)))
				entity.Ignore(e => e.OrmsFcGroupCodes);
			else
	            entity.HasOne(d => d.OrmsFcGroupCodes)
	                .WithMany(p => p.OrmsFcGroupDtls)
	                .HasForeignKey(d => new { d.Resort, d.CodeType, d.GroupCode })
	                .HasConstraintName("FGD_FGC_FK");
        });
	}
}
