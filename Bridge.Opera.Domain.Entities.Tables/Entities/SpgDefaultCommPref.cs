namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SpgDefaultCommPref
{
    public string Resort { get; set; }
    public string TopicType { get; set; }
    public decimal? SpgTopicId { get; set; }
    public string TopicDescription { get; set; }
    public decimal OperaTopicId { get; set; }
    public decimal ParentOperaTopicId { get; set; }
    public string NodeType { get; set; }
    public string OptInYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string DisplayYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpgDefaultCommPref>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SPG_DEFAULT_COMM_PREF");

            entity.HasIndex(e => new { e.Resort, e.TopicType, e.OperaTopicId })
                .HasName("SPG_DEFAULT_COMM_PREF_IND1");

            entity.HasIndex(e => new { e.Resort, e.TopicType, e.ParentOperaTopicId })
                .HasName("SPG_DEFAULT_COMM_PREF_IND2");

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NodeType)
                .IsRequired()
                .HasColumnName("NODE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OperaTopicId)
                .HasColumnName("OPERA_TOPIC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OptInYn)
                .IsRequired()
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
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SpgTopicId)
                .HasColumnName("SPG_TOPIC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TopicDescription)
                .IsRequired()
                .HasColumnName("TOPIC_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TopicType)
                .IsRequired()
                .HasColumnName("TOPIC_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
