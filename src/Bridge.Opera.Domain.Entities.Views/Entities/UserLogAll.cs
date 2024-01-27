namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UserLogAll
{
    public string LogUser { get; set; }
    public string InsertTime { get; set; }
    public DateTime? InsertDateProperty { get; set; }
    public DateTime? InsertDate { get; set; }
    public string StationId { get; set; }
    public string ActionType { get; set; }
    public string ActionTypeStored { get; set; }
    public string ActionDescription { get; set; }
    public decimal? InsertUser { get; set; }
    public string TableName { get; set; }
    public decimal? ActionId { get; set; }
    public decimal? NameId { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserLogAll>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USER_LOG_ALL");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.ActionTypeStored)
                .HasColumnName("ACTION_TYPE_STORED")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDateProperty)
                .HasColumnName("INSERT_DATE_PROPERTY")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertTime)
                .HasColumnName("INSERT_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LogUser)
                .HasColumnName("LOG_USER")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.StationId)
                .HasColumnName("STATION_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(27)
                .IsUnicode(false);
        });
	}
}
