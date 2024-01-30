namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameGoalRevtypes
{
    public decimal? GoalId { get; set; }
    public string? RevType { get; set; }
    public string? RevGroup { get; set; }
    public decimal? Amount { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual NameGoal Goal { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameGoalRevtypes>(entity =>
        {
            entity.HasKey(e => new { e.GoalId, e.RevType })
                .HasName("NGR_PK");

            entity.ToTable("NAME$GOAL_REVTYPES");

            entity.HasIndex(e => e.RevType)
                .HasName("NGR_REVT_FK_I");

            entity.Property(e => e.GoalId)
                .HasColumnName("GOAL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(NameGoal)))
				entity.Ignore(e => e.Goal);
			else
	            entity.HasOne(d => d.Goal)
	                .WithMany(p => p.NameGoalRevtypes)
	                .HasForeignKey(d => d.GoalId)
	                .HasConstraintName("NGR_NGOAL_FK");
        });
	}
}
