namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Tlpcomm
{
    public string Hotelcode { get; set; }
    public string Groupid { get; set; }
    public string Workstatid { get; set; }
    public string Opcode { get; set; }
    public string Transtime { get; set; }
    public string Msgtext { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tlpcomm>(entity =>
        {
            entity.HasKey(e => new { e.Hotelcode, e.Groupid, e.Workstatid, e.Opcode })
                .HasName("TLPC_PK");

            entity.ToTable("TLPCOMM");

            entity.Property(e => e.Hotelcode)
                .HasColumnName("HOTELCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Groupid)
                .HasColumnName("GROUPID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Workstatid)
                .HasColumnName("WORKSTATID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Opcode)
                .HasColumnName("OPCODE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.Msgtext)
                .HasColumnName("MSGTEXT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Transtime)
                .HasColumnName("TRANSTIME")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
