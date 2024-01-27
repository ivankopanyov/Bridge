namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BusinessProfileOwner
{
    public decimal ProfileId { get; set; }
    public string UserResort { get; set; }
    public decimal UserId { get; set; }
    public string PrimaryYn { get; set; }
    public string Relationship { get; set; }
    public string ToType { get; set; }
    public string Description { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

    public virtual BusinessProfile Profile { get; set; }
    public virtual Name User { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BusinessProfileOwner>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.UserResort, e.UserId })
                .HasName("BPO_PK");

            entity.ToTable("BUSINESS$PROFILE_OWNER");

            entity.HasIndex(e => e.UserId)
                .HasName("BPO_NAME_FK_IDX");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserResort)
                .HasColumnName("USER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
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

			if (!types.Contains(typeof(BusinessProfile)))
				entity.Ignore(e => e.Profile);
			else
	            entity.HasOne(d => d.Profile)
	                .WithMany(p => p.BusinessProfileOwner)
	                .HasForeignKey(d => d.ProfileId)
	                .HasConstraintName("BPO_BP_FK");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.User);
			else
	            entity.HasOne(d => d.User)
	                .WithMany(p => p.BusinessProfileOwner)
	                .HasForeignKey(d => d.UserId)
	                .HasConstraintName("BPO_NAME_FK");
        });
	}
}
