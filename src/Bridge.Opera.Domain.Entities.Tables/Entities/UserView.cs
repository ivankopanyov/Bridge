namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UserView
{
    public decimal ViewId { get; set; }
    public string FormName { get; set; }
    public decimal? UserId { get; set; }
    public decimal? GridId { get; set; }
    public decimal? FilterId { get; set; }
    public string Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual FilterHeader Filter { get; set; }
    public virtual GridHeader Grid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserView>(entity =>
        {
            entity.HasKey(e => e.ViewId)
                .HasName("UV_PK");

            entity.ToTable("USER$VIEW");

            entity.HasIndex(e => e.FilterId)
                .HasName("UV_FH_IDX");

            entity.HasIndex(e => e.GridId)
                .HasName("UV_GH_IDX");

            entity.HasIndex(e => new { e.FormName, e.UserId })
                .HasName("UV_UK")
                .IsUnique();

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FilterId)
                .HasColumnName("FILTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GridId)
                .HasColumnName("GRID_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(FilterHeader)))
				entity.Ignore(e => e.Filter);
			else
	            entity.HasOne(d => d.Filter)
	                .WithMany(p => p.UserView)
	                .HasForeignKey(d => d.FilterId)
	                .HasConstraintName("UV_FH_FK");

			if (!types.Contains(typeof(GridHeader)))
				entity.Ignore(e => e.Grid);
			else
	            entity.HasOne(d => d.Grid)
	                .WithMany(p => p.UserView)
	                .HasForeignKey(d => d.GridId)
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("UV_GH_FK");
        });
	}
}
