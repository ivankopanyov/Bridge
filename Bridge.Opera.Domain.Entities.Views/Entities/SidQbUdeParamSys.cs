namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidQbUdeParamSys
{
    public string UdeCode { get; set; }
    public string ParamName { get; set; }
    public string ParamLabel { get; set; }
    public string ParamDesc { get; set; }
    public string DataType { get; set; }
    public string DefaultValue { get; set; }
    public string LovQuery { get; set; }
    public string RegExpr { get; set; }
    public string MinValue { get; set; }
    public string MaxValue { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? DefaultDvalue { get; set; }
    public decimal? DefaultNvalue { get; set; }
    public DateTime? MinDvalue { get; set; }
    public DateTime? MaxDvalue { get; set; }
    public decimal? MinNvalue { get; set; }
    public decimal? MaxNvalue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidQbUdeParamSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_QB_UDE_PARAM_SYS");

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultDvalue)
                .HasColumnName("DEFAULT_DVALUE")
                .HasColumnType("DATE");

            entity.Property(e => e.DefaultNvalue)
                .HasColumnName("DEFAULT_NVALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LovQuery)
                .HasColumnName("LOV_QUERY")
                .IsUnicode(false);

            entity.Property(e => e.MaxDvalue)
                .HasColumnName("MAX_DVALUE")
                .HasColumnType("DATE");

            entity.Property(e => e.MaxNvalue)
                .HasColumnName("MAX_NVALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxValue)
                .HasColumnName("MAX_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.MinDvalue)
                .HasColumnName("MIN_DVALUE")
                .HasColumnType("DATE");

            entity.Property(e => e.MinNvalue)
                .HasColumnName("MIN_NVALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinValue)
                .HasColumnName("MIN_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.ParamDesc)
                .HasColumnName("PARAM_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ParamLabel)
                .HasColumnName("PARAM_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ParamName)
                .IsRequired()
                .HasColumnName("PARAM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RegExpr)
                .HasColumnName("REG_EXPR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UdeCode)
                .IsRequired()
                .HasColumnName("UDE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
