//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Query.g by ANTLR 4.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace RSql4Net.Models.Queries {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="QueryParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public interface IQueryVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelector([NotNull] QueryParser.SelectorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.eval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEval([NotNull] QueryParser.EvalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.or"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOr([NotNull] QueryParser.OrContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.and"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnd([NotNull] QueryParser.AndContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstraint([NotNull] QueryParser.ConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroup([NotNull] QueryParser.GroupContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparison([NotNull] QueryParser.ComparisonContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.comparator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparator([NotNull] QueryParser.ComparatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.comp_fiql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComp_fiql([NotNull] QueryParser.Comp_fiqlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.comp_alt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComp_alt([NotNull] QueryParser.Comp_altContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.reserved"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReserved([NotNull] QueryParser.ReservedContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.single_quote"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingle_quote([NotNull] QueryParser.Single_quoteContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.double_quote"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDouble_quote([NotNull] QueryParser.Double_quoteContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArguments([NotNull] QueryParser.ArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="QueryParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue([NotNull] QueryParser.ValueContext context);
}
} // namespace RSql4Net.Models.Queries
