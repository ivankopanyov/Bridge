namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrackitTypes
{
    public string Resort { get; set; }
    public string TiGroup { get; set; }
    public string TiSubgroup { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string DefaultYn { get; set; }
    public string ActionStatus { get; set; }
    public string TrackitTypesUrl { get; set; }
    public decimal? DisplaySequence { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string SendMessageYn { get; set; }
    public string MessageText { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrackitTypes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TiGroup, e.TiSubgroup, e.Code })
                .HasName("TRACKIT_PK");

            entity.ToTable("TRACKIT_TYPES");

            entity.HasIndex(e => new { e.Resort, e.TiGroup, e.Code })
                .HasName("TRACKIT_GROUP_CODE_IDX");

            entity.HasIndex(e => new { e.Resort, e.TiSubgroup, e.Code })
                .HasName("TRACKIT_SUBGROUP_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TiGroup)
                .HasColumnName("TI_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TiSubgroup)
                .HasColumnName("TI_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionStatus)
                .HasColumnName("ACTION_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplaySequence)
                .HasColumnName("DISPLAY_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MessageText)
                .HasColumnName("MESSAGE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SendMessageYn)
                .HasColumnName("SEND_MESSAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrackitTypesUrl)
                .HasColumnName("TRACKIT_TYPES_URL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
