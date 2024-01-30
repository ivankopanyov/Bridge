namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BusinessProfileLink1
{
    public decimal? ProfileId { get; set; }
    public string? LinkType { get; set; }
    public decimal? LinkId { get; set; }
    public string? PrimaryYn { get; set; }
    public string? Relationship { get; set; }
    public string? ToType { get; set; }
    public string? Description { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BusinessProfileLink1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BUSINESS_PROFILE_LINK");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkType)
                .IsRequired()
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Relationship)
                .HasColumnName("RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToType)
                .HasColumnName("TO_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
