namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidGdsConvRestTypeSys
{
    public string GdsRestrictionType { get; set; }
    public string Description { get; set; }
    public string RestrictionType { get; set; }
    public string BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidGdsConvRestTypeSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_GDS_CONV_REST_TYPE_SYS");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasMaxLength(33)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsRestrictionType)
                .IsRequired()
                .HasColumnName("GDS_RESTRICTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RestrictionType)
                .IsRequired()
                .HasColumnName("RESTRICTION_TYPE")
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
