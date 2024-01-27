namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntParameters
{
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public string ParameterGroup { get; set; }
    public string ParameterName { get; set; }
    public string ParameterValue { get; set; }
    public string Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string LovValues { get; set; }
    public string Explanation { get; set; }
    public string UsedIn { get; set; }
    public string DisplayYn { get; set; }
    public string UsedInApp { get; set; }
    public string UpperCase { get; set; }
    public string EnabledYn { get; set; }
    public string DisplayName { get; set; }

    public virtual IntInterfaceSetup IntInterfaceSetup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntParameters>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_PARAMETERS");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort, e.ParameterName })
                .HasName("INT_PARM_IDX1");

            entity.HasIndex(e => new { e.ParameterName, e.Resort, e.InterfaceId })
                .HasName("INT_PARAMETERS_UK")
                .IsUnique();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.EnabledYn)
                .HasColumnName("ENABLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Explanation)
                .HasColumnName("EXPLANATION")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LovValues)
                .HasColumnName("LOV_VALUES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ParameterGroup)
                .HasColumnName("PARAMETER_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpperCase)
                .IsRequired()
                .HasColumnName("UPPER_CASE")
                .HasColumnType("CHAR(1)")
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.UsedIn)
                .HasColumnName("USED_IN")
                .IsUnicode(false);

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(IntInterfaceSetup)))
				entity.Ignore(e => e.IntInterfaceSetup);
			else
	            entity.HasOne(d => d.IntInterfaceSetup)
	                .WithMany()
	                .HasForeignKey(d => new { d.InterfaceId, d.Resort })
	                .HasConstraintName("INT_PARAMETER_INT_IC_FK");
        });
	}
}
