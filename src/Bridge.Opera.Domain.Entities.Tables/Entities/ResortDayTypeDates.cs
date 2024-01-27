namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortDayTypeDates
{
    public string Resort { get; set; }
    public DateTime DtDate { get; set; }
    public string DtCode { get; set; }
    public decimal? RankValue { get; set; }

    public virtual ResortDayType ResortDayType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortDayTypeDates>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_DAY_TYPE_DATES");

            entity.HasIndex(e => new { e.Resort, e.DtCode })
                .HasName("DAY_TYPE_DATES_FKI");

            entity.HasIndex(e => new { e.Resort, e.DtDate, e.DtCode })
                .HasName("DAY_TYPE_DATES_PK")
                .IsUnique();

            entity.Property(e => e.DtCode)
                .HasColumnName("DT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DtDate)
                .HasColumnName("DT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RankValue)
                .HasColumnName("RANK_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ResortDayType)))
				entity.Ignore(e => e.ResortDayType);
			else
	            entity.HasOne(d => d.ResortDayType)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.DtCode })
	                .HasConstraintName("DAY_TYPE_DATES_FK");
        });
	}
}
