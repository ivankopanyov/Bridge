namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentRemoteOwners
{
    public decimal? AllotRemoteOwnerId { get; set; }
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? OwnerResort { get; set; }
    public string? OwnerCode { get; set; }
    public string? OwnerType { get; set; }
    public string? OwnerOrigin { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? PrimaryEmail { get; set; }
    public string? PrimaryPhone { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentRemoteOwners>(entity =>
        {
            entity.HasKey(e => e.AllotRemoteOwnerId)
                .HasName("ALLOT_REMOTE_OWNERS_PK");

            entity.ToTable("ALLOTMENT$REMOTE_OWNERS");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("ALLOT_REMOTE_OWNERS_IDX1");

            entity.HasIndex(e => new { e.OwnerResort, e.OwnerCode })
                .HasName("ALLOT_REMOTE_OWNERS_IDX2");

            entity.Property(e => e.AllotRemoteOwnerId)
                .HasColumnName("ALLOT_REMOTE_OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerCode)
                .IsRequired()
                .HasColumnName("OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerOrigin)
                .IsRequired()
                .HasColumnName("OWNER_ORIGIN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerResort)
                .IsRequired()
                .HasColumnName("OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerType)
                .IsRequired()
                .HasColumnName("OWNER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryEmail)
                .HasColumnName("PRIMARY_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrimaryPhone)
                .HasColumnName("PRIMARY_PHONE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
	                .WithMany(p => p.AllotmentRemoteOwners)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .HasConstraintName("ARO_AH_FK");
        });
	}
}
