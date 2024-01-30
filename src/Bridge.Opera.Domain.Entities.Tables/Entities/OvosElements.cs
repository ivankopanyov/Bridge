namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosElements
{
    public OvosElements()
    {
        OvosContractElements = new HashSet<OvosContractElements>();
    }

    public string? Resort { get; set; }
    public string? ElementCode { get; set; }
    public string? Description { get; set; }
    public decimal? ElementPoints { get; set; }
    public string? TrxCode { get; set; }
    public decimal? DisplaySeq { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<OvosContractElements> OvosContractElements { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosElements>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ElementCode })
                .HasName("OVOS_ELEMENTS_PK");

            entity.ToTable("OVOS_ELEMENTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ElementCode)
                .HasColumnName("ELEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ElementPoints)
                .HasColumnName("ELEMENT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(OvosContractElements)))
				entity.Ignore(e => e.OvosContractElements);
		});
	}
}
