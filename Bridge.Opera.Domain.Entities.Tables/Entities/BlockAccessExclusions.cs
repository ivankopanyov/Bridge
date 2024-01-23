namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BlockAccessExclusions
{
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public string AccessSourceType { get; set; }
    public string AccessSourceValue { get; set; }
    public string PermModify { get; set; }
    public string PermCancel { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string PermCreate { get; set; }
    public string HideFromAvailYn { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BlockAccessExclusions>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AllotmentHeaderId, e.AccessSourceType, e.AccessSourceValue })
                .HasName("BAN_PK");

            entity.ToTable("BLOCK_ACCESS_EXCLUSIONS");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("BAN_AH_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccessSourceType)
                .HasColumnName("ACCESS_SOURCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccessSourceValue)
                .HasColumnName("ACCESS_SOURCE_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.HideFromAvailYn)
                .HasColumnName("HIDE_FROM_AVAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermCancel)
                .HasColumnName("PERM_CANCEL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PermCreate)
                .HasColumnName("PERM_CREATE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PermModify)
                .HasColumnName("PERM_MODIFY")
                .HasMaxLength(1)
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
	                .WithMany(p => p.BlockAccessExclusions)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .HasConstraintName("BAN_ALR_FK");
        });
	}
}
