namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsConvRestrictionTypes
{
    public string GdsRestrictionType { get; set; }
    public string Description { get; set; }
    public string RestrictionType { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsConvRestrictionTypes>(entity =>
        {
            entity.HasKey(e => new { e.GdsRestrictionType, e.RestrictionType, e.BeginDate })
                .HasName("GDS_CONV_RES_TYPE_PK");

            entity.ToTable("GDS_CONV_RESTRICTION_TYPES");

            entity.HasIndex(e => new { e.RestrictionType, e.BeginDate })
                .HasName("GDS_RESTRICTIONS_IND1");

            entity.Property(e => e.GdsRestrictionType)
                .HasColumnName("GDS_RESTRICTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionType)
                .HasColumnName("RESTRICTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
