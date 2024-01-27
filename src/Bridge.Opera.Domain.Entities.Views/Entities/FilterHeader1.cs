namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FilterHeader1
{
    public decimal FilterId { get; set; }
    public string Filtername { get; set; }
    public string Descr { get; set; }
    public decimal? OwnerUser { get; set; }
    public decimal? GroupId { get; set; }
    public string Resort { get; set; }
    public string WhereClause { get; set; }
    public string GlobalYn { get; set; }
    public string Caller { get; set; }
    public decimal? GridId { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FilterHeader1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FILTER_HEADER");

            entity.Property(e => e.Caller)
                .HasColumnName("CALLER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Descr)
                .HasColumnName("DESCR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FilterId)
                .HasColumnName("FILTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Filtername)
                .IsRequired()
                .HasColumnName("FILTERNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GridId)
                .HasColumnName("GRID_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerUser)
                .HasColumnName("OWNER_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WhereClause)
                .HasColumnName("WHERE_CLAUSE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
