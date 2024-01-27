namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentDateProtection
{
    public decimal AllotmentProtectionId { get; set; }
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public DateTime? ProtectionDate { get; set; }
    public string ProtectionType { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentDateProtection>(entity =>
        {
            entity.HasKey(e => e.AllotmentProtectionId)
                .HasName("ALLOTMENT_DATE_PROTECTION_PK");

            entity.ToTable("ALLOTMENT_DATE_PROTECTION");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort, e.ProtectionDate, e.ProtectionType })
                .HasName("ALLOTMENT_DATE_PROTECTION_UK")
                .IsUnique();

            entity.Property(e => e.AllotmentProtectionId)
                .HasColumnName("ALLOTMENT_PROTECTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProtectionDate)
                .HasColumnName("PROTECTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProtectionType)
                .IsRequired()
                .HasColumnName("PROTECTION_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.AllotmentDateProtection)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .HasConstraintName("ADP_AH_FK");
        });
	}
}
