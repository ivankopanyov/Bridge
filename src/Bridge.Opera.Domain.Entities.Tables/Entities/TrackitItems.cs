namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrackitItems
{
    public string? Resort { get; set; }
    public decimal? TrackitId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? TicketNo { get; set; }
    public string? ReferenceNo { get; set; }
    public string? TiGroup { get; set; }
    public DateTime? FollowUp { get; set; }
    public string? Status { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public DateTime? BusinessDateResolved { get; set; }
    public decimal? ResolvedUser { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public string? Action { get; set; }
    public string? TrackitType { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Msgid { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ExternalId { get; set; }
    public decimal? AssignedTo { get; set; }

    public virtual Name GuestName { get; set; }
    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrackitItems>(entity =>
        {
            entity.HasKey(e => e.TrackitId)
                .HasName("TRACKIT_ITEMS_PK");

            entity.ToTable("TRACKIT_ITEMS");

            entity.HasIndex(e => e.GuestNameId)
                .HasName("TRACKIT_NAME_FKI");

            entity.HasIndex(e => new { e.Resort, e.ExternalId })
                .HasName("TRACKIT_EXTID_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("TRACKIT_RESV_FKI");

            entity.HasIndex(e => new { e.Resort, e.TicketNo })
                .HasName("TRACKIT_TICKET_IDX");

            entity.HasIndex(e => new { e.Resort, e.Status, e.FollowUp })
                .HasName("TRACKIT_STATUS_IDX");

            entity.HasIndex(e => new { e.Resort, e.TiGroup, e.Action })
                .HasName("TRACKIT_GROUPACTION_IDX");

            entity.HasIndex(e => new { e.Resort, e.TiGroup, e.Status })
                .HasName("TRACKIT_GROUP_IDX");

            entity.Property(e => e.TrackitId)
                .HasColumnName("TRACKIT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignedTo)
                .HasColumnName("ASSIGNED_TO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDateResolved)
                .HasColumnName("BUSINESS_DATE_RESOLVED")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalId)
                .HasColumnName("EXTERNAL_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FollowUp)
                .HasColumnName("FOLLOW_UP")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Location)
                .HasColumnName("LOCATION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Msgid)
                .HasColumnName("MSGID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReferenceNo)
                .HasColumnName("REFERENCE_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedUser)
                .HasColumnName("RESOLVED_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TiGroup)
                .IsRequired()
                .HasColumnName("TI_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TicketNo)
                .HasColumnName("TICKET_NO")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrackitType)
                .HasColumnName("TRACKIT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.GuestName);
			else
	            entity.HasOne(d => d.GuestName)
	                .WithMany(p => p.TrackitItems)
	                .HasForeignKey(d => d.GuestNameId)
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("TRACKIT_NAME_FK");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.TrackitItems)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("TRACKIT_RESV_FK");
        });
	}
}
