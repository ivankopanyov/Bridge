namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActivityLink
{
    public decimal ActId { get; set; }
    public string LinkType { get; set; }
    public decimal LinkId { get; set; }
    public string PrimaryYn { get; set; }
    public byte? LaptopChange { get; set; }
    public string ActResort { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? AddressId { get; set; }
    public decimal? EmailId { get; set; }
    public string AttachmentYn { get; set; }
    public string LinkResort { get; set; }
    public string Relationship { get; set; }
    public string ToType { get; set; }

    public virtual WorkOrders Act { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActivityLink>(entity =>
        {
            entity.HasKey(e => new { e.ActId, e.LinkType, e.LinkId })
                .HasName("ACTIVITY_LINK_PK");

            entity.ToTable("ACTIVITY$LINK");

            entity.HasIndex(e => e.LinkId)
                .HasName("AL_LINK_ID_IND");

            entity.HasIndex(e => new { e.ActId, e.ActResort })
                .HasName("AL_WO_CHILD_OF_FK_I");

            entity.HasIndex(e => new { e.LinkType, e.LinkId })
                .HasName("AL_LINKTYPE_IDX");

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkType)
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActResort)
                .HasColumnName("ACT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttachmentYn)
                .HasColumnName("ATTACHMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.LinkResort)
                .HasColumnName("LINK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Relationship)
                .HasColumnName("RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToType)
                .HasColumnName("TO_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.Act);
			else
	            entity.HasOne(d => d.Act)
	                .WithMany(p => p.ActivityLink)
	                .HasForeignKey(d => new { d.ActId, d.ActResort })
	                .HasConstraintName("ACTLINK_FK1");
        });
	}
}
