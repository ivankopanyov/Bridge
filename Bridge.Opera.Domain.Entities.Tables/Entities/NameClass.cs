namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameClass
{
    public NameClass()
    {
        BroadcastRules = new HashSet<BroadcastRules>();
    }

    public string NameType { get; set; }
    public string NameClass1 { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string Description { get; set; }
    public string RelationCategory { get; set; }
    public string RelationAllowedYn { get; set; }

    public virtual ICollection<BroadcastRules> BroadcastRules { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameClass>(entity =>
        {
            entity.HasKey(e => e.NameType)
                .HasName("NAME_CLASS_PK");

            entity.ToTable("NAME$_CLASS");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameClass1)
                .IsRequired()
                .HasColumnName("NAME_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationAllowedYn)
                .HasColumnName("RELATION_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RelationCategory)
                .IsRequired()
                .HasColumnName("RELATION_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(BroadcastRules)))
				entity.Ignore(e => e.BroadcastRules);
		});
	}
}
