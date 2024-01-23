namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameGoalDetails
{
    public decimal NgoalGoalId { get; set; }
    public string GoaltypeCode { get; set; }
    public decimal DetailId { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? RoomAvgRate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual NameGoal NgoalGoal { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameGoalDetails>(entity =>
        {
            entity.HasKey(e => new { e.NgoalGoalId, e.GoaltypeCode, e.DetailId })
                .HasName("NGD_PK");

            entity.ToTable("NAME$GOAL_DETAILS");

            entity.Property(e => e.NgoalGoalId)
                .HasColumnName("NGOAL_GOAL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoaltypeCode)
                .HasColumnName("GOALTYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DetailId)
                .HasColumnName("DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomAvgRate)
                .HasColumnName("ROOM_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(NameGoal)))
				entity.Ignore(e => e.NgoalGoal);
			else
	            entity.HasOne(d => d.NgoalGoal)
	                .WithMany(p => p.NameGoalDetails)
	                .HasForeignKey(d => d.NgoalGoalId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("NGD_NGOAL_FK");
        });
	}
}
