namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RegSqlScript
{
    public string ScriptName { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? RunCounter { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RegSqlScript>(entity =>
        {
            entity.HasKey(e => e.ScriptName)
                .HasName("REG_SQL_PK");

            entity.ToTable("REG_SQL_SCRIPT");

            entity.Property(e => e.ScriptName)
                .HasColumnName("SCRIPT_NAME")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RunCounter)
                .HasColumnName("RUN_COUNTER")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("1 ");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
