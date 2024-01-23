namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SpgCommPrefView
{
    public string Resort { get; set; }
    public string TopicType { get; set; }
    public decimal? SpgTopicId { get; set; }
    public string TopicDescription { get; set; }
    public decimal? OperaTopicId { get; set; }
    public decimal? ParentOperaTopicId { get; set; }
    public string NodeType { get; set; }
    public string OptInYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string DisplayYn { get; set; }
    public decimal? Depth { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpgCommPrefView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SPG_COMM_PREF_VIEW");

            entity.Property(e => e.Depth)
                .HasColumnName("DEPTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NodeType)
                .HasColumnName("NODE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OperaTopicId)
                .HasColumnName("OPERA_TOPIC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OptInYn)
                .HasColumnName("OPT_IN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentOperaTopicId)
                .HasColumnName("PARENT_OPERA_TOPIC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SpgTopicId)
                .HasColumnName("SPG_TOPIC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TopicDescription)
                .HasColumnName("TOPIC_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TopicType)
                .HasColumnName("TOPIC_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
