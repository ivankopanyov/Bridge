namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortAssignmentReasons
{
    public ResortAssignmentReasons()
    {
        Room = new HashSet<Room>();
    }

    public string Resort { get; set; }
    public string AssignReason { get; set; }
    public string AssignType { get; set; }
    public string AssignDesc { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? OrderBy { get; set; }
    public string Comments { get; set; }
    public decimal? HoldMinutes { get; set; }

    public virtual ICollection<Room> Room { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortAssignmentReasons>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AssignReason })
                .HasName("RESORT_ASSIGNMENT_REASONS_PK");

            entity.ToTable("RESORT_ASSIGNMENT_REASONS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignReason)
                .HasColumnName("ASSIGN_REASON")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignDesc)
                .HasColumnName("ASSIGN_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignType)
                .IsRequired()
                .HasColumnName("ASSIGN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HoldMinutes)
                .HasColumnName("HOLD_MINUTES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.Room);
		});
	}
}
