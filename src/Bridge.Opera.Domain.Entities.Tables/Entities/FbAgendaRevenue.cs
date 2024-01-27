namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FbAgendaRevenue
{
    public decimal FbaId { get; set; }
    public string RevType { get; set; }
    public string RevGroup { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? BudgetRevenue { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public string CustomYn { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual FbAgenda Fba { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FbAgendaRevenue>(entity =>
        {
            entity.HasKey(e => new { e.FbaId, e.RevType })
                .HasName("FBAREV_PK");

            entity.ToTable("FB$AGENDA_REVENUE");

            entity.Property(e => e.FbaId)
                .HasColumnName("FBA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BudgetRevenue)
                .HasColumnName("BUDGET_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CustomYn)
                .IsRequired()
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(FbAgenda)))
				entity.Ignore(e => e.Fba);
			else
	            entity.HasOne(d => d.Fba)
	                .WithMany(p => p.FbAgendaRevenue)
	                .HasForeignKey(d => d.FbaId)
	                .HasConstraintName("FBAREV_FBA_FK");
        });
	}
}
