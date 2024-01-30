namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidSpSyntaxSys
{
    public decimal? SyntaxId { get; set; }
    public string? SyntaxMeaning { get; set; }
    public string? Syntax { get; set; }
    public string? SyntaxType { get; set; }
    public string? Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidSpSyntaxSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_SP_SYNTAX_SYS");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Syntax)
                .IsRequired()
                .HasColumnName("SYNTAX")
                .IsUnicode(false);

            entity.Property(e => e.SyntaxId)
                .HasColumnName("SYNTAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SyntaxMeaning)
                .HasColumnName("SYNTAX_MEANING")
                .IsUnicode(false);

            entity.Property(e => e.SyntaxType)
                .IsRequired()
                .HasColumnName("SYNTAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
