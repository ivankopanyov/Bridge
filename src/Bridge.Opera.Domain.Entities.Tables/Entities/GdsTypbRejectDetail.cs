namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsTypbRejectDetail
{
    public decimal? TypbRejectId { get; set; }
    public string? TypbErrorCategory { get; set; }
    public string? TypbErrorAttribute { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? TypbErrorField { get; set; }
    public decimal? SegmentNumber { get; set; }
    public decimal? Sequence { get; set; }
    public string? TypeRetryAttribute { get; set; }

    public virtual GdsTypbRejectHeader TypbReject { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsTypbRejectDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_TYPB_REJECT_DETAIL");

            entity.HasIndex(e => e.TypbRejectId)
                .HasName("GDS_TYPB_REJECT_DETAIL_IND1");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SegmentNumber)
                .HasColumnName("SEGMENT_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TypbErrorAttribute)
                .IsRequired()
                .HasColumnName("TYPB_ERROR_ATTRIBUTE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TypbErrorCategory)
                .IsRequired()
                .HasColumnName("TYPB_ERROR_CATEGORY")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TypbErrorField)
                .HasColumnName("TYPB_ERROR_FIELD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypbRejectId)
                .HasColumnName("TYPB_REJECT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TypeRetryAttribute)
                .HasColumnName("TYPE_RETRY_ATTRIBUTE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsTypbRejectHeader)))
				entity.Ignore(e => e.TypbReject);
			else
	            entity.HasOne(d => d.TypbReject)
	                .WithMany()
	                .HasForeignKey(d => d.TypbRejectId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GDS_TYPB_REJECT_DETAIL_FK1");
        });
	}
}
