namespace CSharpier.SyntaxPrinter;

internal class FormattingContext
{
    public int PrintingDepth { get; set; }
    public bool NextTriviaNeedsLine { get; set; }
    public bool ShouldSkipNextLeadingTrivia { get; set; }
    public bool NewlineBeforeOpenBraceInBlock { get; set; } = false;
    public bool NewlineBeforeOpenBraceInClass { get; set; } = false;
    public required string LineEnding { get; init; }

    // we need to keep track if we reordered modifiers because when modifiers are moved inside
    // of an #if, then we can't compare the before and after disabled text in the source file
    public bool ReorderedModifiers { get; set; }
}
