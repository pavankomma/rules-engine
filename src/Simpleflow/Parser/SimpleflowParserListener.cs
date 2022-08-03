//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Navtech\Opensource\Simpleflow\src\Simpleflow\Parser\Grammar\SimpleflowParser.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Simpleflow.Parser {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SimpleflowParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
internal interface ISimpleflowParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] SimpleflowParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] SimpleflowParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.ruleStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRuleStmt([NotNull] SimpleflowParser.RuleStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.ruleStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRuleStmt([NotNull] SimpleflowParser.RuleStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.endRuleStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndRuleStmt([NotNull] SimpleflowParser.EndRuleStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.endRuleStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndRuleStmt([NotNull] SimpleflowParser.EndRuleStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.exitStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExitStmt([NotNull] SimpleflowParser.ExitStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.exitStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExitStmt([NotNull] SimpleflowParser.ExitStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.generalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneralStatement([NotNull] SimpleflowParser.GeneralStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.generalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneralStatement([NotNull] SimpleflowParser.GeneralStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.letStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLetStmt([NotNull] SimpleflowParser.LetStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.letStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLetStmt([NotNull] SimpleflowParser.LetStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.setStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetStmt([NotNull] SimpleflowParser.SetStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.setStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetStmt([NotNull] SimpleflowParser.SetStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.messageStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMessageStmt([NotNull] SimpleflowParser.MessageStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.messageStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMessageStmt([NotNull] SimpleflowParser.MessageStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.errorStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorStmt([NotNull] SimpleflowParser.ErrorStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.errorStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorStmt([NotNull] SimpleflowParser.ErrorStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.messageText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMessageText([NotNull] SimpleflowParser.MessageTextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.messageText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMessageText([NotNull] SimpleflowParser.MessageTextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.outputStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputStmt([NotNull] SimpleflowParser.OutputStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.outputStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputStmt([NotNull] SimpleflowParser.OutputStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.functionStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionStmt([NotNull] SimpleflowParser.FunctionStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.functionStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionStmt([NotNull] SimpleflowParser.FunctionStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.eos"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEos([NotNull] SimpleflowParser.EosContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.eos"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEos([NotNull] SimpleflowParser.EosContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] SimpleflowParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] SimpleflowParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.templateStringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateStringLiteral([NotNull] SimpleflowParser.TemplateStringLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.templateStringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateStringLiteral([NotNull] SimpleflowParser.TemplateStringLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.templateStringAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateStringAtom([NotNull] SimpleflowParser.TemplateStringAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.templateStringAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateStringAtom([NotNull] SimpleflowParser.TemplateStringAtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.arithmeticExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpression([NotNull] SimpleflowParser.ArithmeticExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.arithmeticExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpression([NotNull] SimpleflowParser.ArithmeticExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] SimpleflowParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] SimpleflowParser.AtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] SimpleflowParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] SimpleflowParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.functionParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionParameter([NotNull] SimpleflowParser.FunctionParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.functionParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionParameter([NotNull] SimpleflowParser.FunctionParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.functionParameterValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionParameterValue([NotNull] SimpleflowParser.FunctionParameterValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.functionParameterValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionParameterValue([NotNull] SimpleflowParser.FunctionParameterValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.objectIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectIdentifier([NotNull] SimpleflowParser.ObjectIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.objectIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectIdentifier([NotNull] SimpleflowParser.ObjectIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.stringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringLiteral([NotNull] SimpleflowParser.StringLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.stringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringLiteral([NotNull] SimpleflowParser.StringLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.numberLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberLiteral([NotNull] SimpleflowParser.NumberLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.numberLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberLiteral([NotNull] SimpleflowParser.NumberLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.boolLeteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolLeteral([NotNull] SimpleflowParser.BoolLeteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.boolLeteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolLeteral([NotNull] SimpleflowParser.BoolLeteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.noneLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoneLiteral([NotNull] SimpleflowParser.NoneLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.noneLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoneLiteral([NotNull] SimpleflowParser.NoneLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.jsonObj"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJsonObj([NotNull] SimpleflowParser.JsonObjContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.jsonObj"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJsonObj([NotNull] SimpleflowParser.JsonObjContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPair([NotNull] SimpleflowParser.PairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPair([NotNull] SimpleflowParser.PairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredicate([NotNull] SimpleflowParser.PredicateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredicate([NotNull] SimpleflowParser.PredicateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.testExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTestExpression([NotNull] SimpleflowParser.TestExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.testExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTestExpression([NotNull] SimpleflowParser.TestExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.logicalOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalOperator([NotNull] SimpleflowParser.LogicalOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.logicalOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalOperator([NotNull] SimpleflowParser.LogicalOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.relationalOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalOperator([NotNull] SimpleflowParser.RelationalOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.relationalOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalOperator([NotNull] SimpleflowParser.RelationalOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperand([NotNull] SimpleflowParser.OperandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperand([NotNull] SimpleflowParser.OperandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleflowParser.unaryOperand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryOperand([NotNull] SimpleflowParser.UnaryOperandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleflowParser.unaryOperand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryOperand([NotNull] SimpleflowParser.UnaryOperandContext context);
}
} // namespace Simpleflow.Parser
