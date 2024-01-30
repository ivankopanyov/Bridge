namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MeetingRoomImages
{
    public decimal? MrimgId { get; set; }
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public string? SetupCode { get; set; }
    public decimal? BlobId { get; set; }
    public string? Label { get; set; }
    public string? Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual OperaImages Blob { get; set; }
    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MeetingRoomImages>(entity =>
        {
            entity.HasKey(e => e.MrimgId)
                .HasName("MRIMG_PK");

            entity.ToTable("MEETING_ROOM$IMAGES");

            entity.HasIndex(e => e.BlobId)
                .HasName("MRIMG_OI_FK_I");

            entity.HasIndex(e => e.Resort)
                .HasName("MRIMG_RESORT_FK_I");

            entity.Property(e => e.MrimgId)
                .HasColumnName("MRIMG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlobId)
                .HasColumnName("BLOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetupCode)
                .HasColumnName("SETUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OperaImages)))
				entity.Ignore(e => e.Blob);
			else
	            entity.HasOne(d => d.Blob)
	                .WithMany(p => p.MeetingRoomImages)
	                .HasForeignKey(d => d.BlobId)
	                .HasConstraintName("MRIMG_OI_FK");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.MeetingRoomImages)
	                .HasForeignKey(d => d.Resort)
	                .HasConstraintName("MRIMG_RESORT_FK");
        });
	}
}
