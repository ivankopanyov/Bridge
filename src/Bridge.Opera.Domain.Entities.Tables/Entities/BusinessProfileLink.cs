namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BusinessProfileLink
{
    public decimal ProfileId { get; set; }
    public string LinkType { get; set; }
    public decimal LinkId { get; set; }
    public string PrimaryYn { get; set; }
    public string Relationship { get; set; }
    public string ToType { get; set; }
    public string Description { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

    public virtual Name Link { get; set; }
    public virtual BusinessProfile Profile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BusinessProfileLink>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.LinkType, e.LinkId })
                .HasName("BPL_PK");

            entity.ToTable("BUSINESS$PROFILE_LINK");

            entity.HasIndex(e => e.LinkId)
                .HasName("BPL_LINK_ID_IND");

            entity.HasIndex(e => new { e.LinkType, e.LinkId })
                .HasName("BPL_LINKTYPE_IDX");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LinkType)
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

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

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Link);
			else
	            entity.HasOne(d => d.Link)
	                .WithMany(p => p.BusinessProfileLink)
	                .HasForeignKey(d => d.LinkId)
	                .HasConstraintName("BPL_NAME_FK");

			if (!types.Contains(typeof(BusinessProfile)))
				entity.Ignore(e => e.Profile);
			else
	            entity.HasOne(d => d.Profile)
	                .WithMany(p => p.BusinessProfileLink)
	                .HasForeignKey(d => d.ProfileId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BPL_BP_FK");
        });
	}
}
