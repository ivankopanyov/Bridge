namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TlgoConfig
{
    public TlgoConfig()
    {
        AllotmentTlgo = new HashSet<AllotmentTlgo>();
    }

    public string Type { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string DetailReqYn { get; set; }
    public string NumberYn { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<AllotmentTlgo> AllotmentTlgo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TlgoConfig>(entity =>
        {
            entity.HasKey(e => new { e.Type, e.Code })
                .HasName("TLGO_CONFIG_PK");

            entity.ToTable("TLGO_CONFIG");

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DetailReqYn)
                .HasColumnName("DETAIL_REQ_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.NumberYn)
                .HasColumnName("NUMBER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(AllotmentTlgo)))
				entity.Ignore(e => e.AllotmentTlgo);
		});
	}
}
