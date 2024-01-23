namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipCardReaderFmt
{
    public string MembershipType { get; set; }
    public string FieldName { get; set; }
    public string FormatType { get; set; }
    public decimal? StartPosition { get; set; }
    public decimal? EndPosition { get; set; }
    public string StartPattern { get; set; }
    public string EndPattern { get; set; }
    public decimal? StartSearchPosition { get; set; }
    public string StartSearchPattern { get; set; }
    public string ChainCode { get; set; }

    public virtual MembershipTypes MembershipTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipCardReaderFmt>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.FieldName, e.MembershipType })
                .HasName("MEMBERSHIP_CARD_READER_FMT_PK");

            entity.ToTable("MEMBERSHIP_CARD_READER_FMT");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType })
                .HasName("MEMBERSHIP_CD_READER_IDX1");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndPattern)
                .HasColumnName("END_PATTERN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndPosition)
                .HasColumnName("END_POSITION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FormatType)
                .HasColumnName("FORMAT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartPattern)
                .HasColumnName("START_PATTERN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartPosition)
                .HasColumnName("START_POSITION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartSearchPattern)
                .HasColumnName("START_SEARCH_PATTERN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartSearchPosition)
                .HasColumnName("START_SEARCH_POSITION")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MembershipTypes)))
				entity.Ignore(e => e.MembershipTypes);
			else
	            entity.HasOne(d => d.MembershipTypes)
	                .WithMany(p => p.MembershipCardReaderFmt)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_CA_MEMBERSHIP_T_FK");
        });
	}
}
