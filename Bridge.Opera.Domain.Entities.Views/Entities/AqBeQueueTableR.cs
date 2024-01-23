namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AqBeQueueTableR
{
    public string Queue { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public decimal? Protocol { get; set; }
    public string Rule { get; set; }
    public string RuleSet { get; set; }
    public string Transformation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AqBeQueueTableR>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AQ$BE_QUEUE_TABLE_R");

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Protocol)
                .HasColumnName("PROTOCOL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Queue)
                .IsRequired()
                .HasColumnName("QUEUE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Rule)
                .HasColumnName("RULE")
                .HasColumnType("CLOB");

            entity.Property(e => e.RuleSet)
                .HasColumnName("RULE_SET")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.Transformation)
                .HasColumnName("TRANSFORMATION")
                .HasMaxLength(65)
                .IsUnicode(false);
        });
	}
}
