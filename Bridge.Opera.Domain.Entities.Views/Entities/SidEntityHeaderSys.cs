namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidEntityHeaderSys
{
    public string EntityName { get; set; }
    public string UserMaintainable { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string Description { get; set; }
    public string PropertyLevelYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidEntityHeaderSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ENTITY_HEADER_SYS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EntityName)
                .IsRequired()
                .HasColumnName("ENTITY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyLevelYn)
                .HasColumnName("PROPERTY_LEVEL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserMaintainable)
                .IsRequired()
                .HasColumnName("USER_MAINTAINABLE")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
