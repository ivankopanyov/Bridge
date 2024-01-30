namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScFielddef
{
    public decimal? FldId { get; set; }
    public string? Tablename { get; set; }
    public string? FldName { get; set; }
    public string? Resort { get; set; }
    public string? Action { get; set; }
    public string? FldValue { get; set; }
    public string? FldFunctionYn { get; set; }
    public string? CustomYn { get; set; }
    public string? ParentYn { get; set; }
    public string? ComputeDateYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScFielddef>(entity =>
        {
            entity.HasKey(e => e.FldId)
                .HasName("FIELDDEF_PK");

            entity.ToTable("SC$FIELDDEF");

            entity.HasIndex(e => new { e.Resort, e.FldName, e.Action, e.Tablename })
                .HasName("FLDDEF_UK")
                .IsUnique();

            entity.Property(e => e.FldId)
                .HasColumnName("FLD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ComputeDateYn)
                .HasColumnName("COMPUTE_DATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.CustomYn)
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.FldFunctionYn)
                .HasColumnName("FLD_FUNCTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FldName)
                .IsRequired()
                .HasColumnName("FLD_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FldValue)
                .HasColumnName("FLD_VALUE")
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentYn)
                .HasColumnName("PARENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tablename)
                .IsRequired()
                .HasColumnName("TABLENAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ScFielddef)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("SFD_RESORT_FK");
        });
	}
}
