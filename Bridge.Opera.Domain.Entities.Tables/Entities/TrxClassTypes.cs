namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxClassTypes
{
    public TrxClassTypes()
    {
        TcGroupsTctClassType1Navigation = new HashSet<TcGroups>();
        TcGroupsTctClassType2Navigation = new HashSet<TcGroups>();
        TrxClasses = new HashSet<TrxClasses>();
    }

    public string TypeType { get; set; }
    public string DescriptionDescription { get; set; }
    public string TctType { get; set; }
    public string Description { get; set; }

    public virtual ICollection<TcGroups> TcGroupsTctClassType1Navigation { get; set; }
    public virtual ICollection<TcGroups> TcGroupsTctClassType2Navigation { get; set; }
    public virtual ICollection<TrxClasses> TrxClasses { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxClassTypes>(entity =>
        {
            entity.HasKey(e => e.TctType)
                .HasName("TRX_CLASS_TYPES_PK");

            entity.ToTable("TRX_CLASS_TYPES");

            entity.Property(e => e.TctType)
                .HasColumnName("TCT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DescriptionDescription)
                .HasColumnName("DESCRIPTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TypeType)
                .HasColumnName("TYPE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(TcGroups)))
				entity.Ignore(e => e.TcGroupsTctClassType1Navigation);

			if (!types.Contains(typeof(TcGroups)))
				entity.Ignore(e => e.TcGroupsTctClassType2Navigation);

			if (!types.Contains(typeof(TrxClasses)))
				entity.Ignore(e => e.TrxClasses);
		});
	}
}
