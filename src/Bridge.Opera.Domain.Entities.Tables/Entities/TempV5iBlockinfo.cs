namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempV5iBlockinfo
{
    public string? Hotelcode { get; set; }
    public decimal? Groupid { get; set; }
    public string? Blockcode { get; set; }
    public string? Groupname { get; set; }
    public decimal? Mastergroupid { get; set; }
    public string? Status { get; set; }
    public string? Mktseg { get; set; }
    public DateTime? Arrdate { get; set; }
    public DateTime? Depdate { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Grouptype { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempV5iBlockinfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_V5I_BLOCKINFO");

            entity.Property(e => e.Arrdate)
                .HasColumnName("ARRDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Blockcode)
                .HasColumnName("BLOCKCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Depdate)
                .HasColumnName("DEPDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Groupid)
                .HasColumnName("GROUPID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Groupname)
                .HasColumnName("GROUPNAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Grouptype)
                .HasColumnName("GROUPTYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Hotelcode)
                .IsRequired()
                .HasColumnName("HOTELCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Mastergroupid)
                .HasColumnName("MASTERGROUPID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Mktseg)
                .HasColumnName("MKTSEG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
