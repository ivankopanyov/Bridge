namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameGoalRevtypes1
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

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameGoalRevtypes1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_GOAL_REVTYPES");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalId)
                .HasColumnName("GOAL_ID")
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

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
