namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GridHeader
{
    public GridHeader()
    {
        UserView = new HashSet<UserView>();
    }

    public decimal? GridId { get; set; }
    public string? FormName { get; set; }
    public decimal? UserId { get; set; }
    public decimal? GroupId { get; set; }
    public string? Resort { get; set; }
    public decimal? ColourId { get; set; }
    public string? TableName { get; set; }
    public string? GridName { get; set; }
    public string? FooterYn { get; set; }
    public string? GroupBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? SubtotalsYn { get; set; }
    public string? ChainCode { get; set; }

    public virtual ColourHeader C { get; set; }
    public virtual ICollection<UserView> UserView { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GridHeader>(entity =>
        {
            entity.HasKey(e => e.GridId)
                .HasName("GH_PK");

            entity.ToTable("GRID$HEADER");

            entity.HasIndex(e => new { e.ColourId, e.ChainCode })
                .HasName("GH_COLORID_IDX");

            entity.HasIndex(e => new { e.FormName, e.UserId, e.GridName, e.GroupId, e.Resort })
                .HasName("GH_FRM_UID_GRIDNAME_IDX")
                .IsUnique();

            entity.Property(e => e.GridId)
                .HasColumnName("GRID_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ColourId)
                .HasColumnName("COLOUR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FooterYn)
                .HasColumnName("FOOTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GridName)
                .HasColumnName("GRID_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.GroupBy)
                .HasColumnName("GROUP_BY")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SubtotalsYn)
                .HasColumnName("SUBTOTALS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ColourHeader)))
				entity.Ignore(e => e.C);
			else
	            entity.HasOne(d => d.C)
	                .WithMany(p => p.GridHeader)
	                .HasForeignKey(d => new { d.ColourId, d.ChainCode })
	                .HasConstraintName("GH_CH_FK");
        
			if (!types.Contains(typeof(UserView)))
				entity.Ignore(e => e.UserView);
		});
	}
}
