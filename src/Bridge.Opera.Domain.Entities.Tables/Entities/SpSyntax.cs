namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SpSyntax
{
    public decimal? SyntaxId { get; set; }
    public string? SyntaxMeaning { get; set; }
    public string? SyntaxType { get; set; }
    public string? Syntax { get; set; }
    public string? Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpSyntax>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SP_SYNTAX");

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
