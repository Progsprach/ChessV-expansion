//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\greg\workspace\ChessVCParser\ChessVC.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class ChessVCLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, T__48=49, LINE_COMMENT=50, COMMENT=51, WHITESPACE=52, 
		ATTRIBUTE=53, IDENTIFIER=54, CHAR=55, STRING=56, INTEGER=57;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "T__48", 
		"LINE_COMMENT", "COMMENT", "WHITESPACE", "STR_ESC", "ATTRIBUTE", "IDENTIFIER", 
		"ID_ESC", "CHAR", "STRING", "DIGIT", "INTEGER"
	};


	public ChessVCLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'PieceType'", "'{'", "'}'", "'Game'", "':'", "'='", "';'", "'true'", 
		"'false'", "'('", "')'", "'.'", "'+'", "'-'", "'<'", "'>'", "'<='", "'>='", 
		"'=='", "'!='", "'&&'", "'||'", "'if'", "'else'", "'return'", "'var'", 
		"'local'", "'['", "']'", "'++'", "'--'", "'!'", "'*'", "'/'", "'%'", "'?'", 
		"'+='", "'-='", "','", "'Int'", "'IntRange'", "'String'", "'Bool'", "'Choice'", 
		"'..'", "'MirrorSymmetry'", "'RotationalSymmetry'", "'NoSymmetry'", "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, "LINE_COMMENT", "COMMENT", "WHITESPACE", "ATTRIBUTE", "IDENTIFIER", 
		"CHAR", "STRING", "INTEGER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ChessVC.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2;\x1A9");
		sb.Append("\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6");
		sb.Append("\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r");
		sb.Append("\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4\x12");
		sb.Append("\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16\x4");
		sb.Append("\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B\t\x1B");
		sb.Append("\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t ");
		sb.Append("\x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t");
		sb.Append("(\x4)\t)\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t");
		sb.Append("\x30\x4\x31\t\x31\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4");
		sb.Append("\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37\x4\x38\t\x38\x4\x39\t\x39");
		sb.Append("\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3");
		sb.Append("\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3");
		sb.Append("\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3");
		sb.Append("\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3");
		sb.Append("\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11");
		sb.Append("\x3\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14\x3");
		sb.Append("\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17");
		sb.Append("\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3");
		sb.Append("\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A");
		sb.Append("\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3");
		sb.Append("\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F");
		sb.Append("\x3 \x3 \x3 \x3!\x3!\x3\"\x3\"\x3#\x3#\x3$\x3$\x3%\x3%\x3&\x3");
		sb.Append("&\x3&\x3\'\x3\'\x3\'\x3(\x3(\x3)\x3)\x3)\x3)\x3*\x3*\x3*\x3");
		sb.Append("*\x3*\x3*\x3*\x3*\x3*\x3+\x3+\x3+\x3+\x3+\x3+\x3+\x3,\x3,\x3");
		sb.Append(",\x3,\x3,\x3-\x3-\x3-\x3-\x3-\x3-\x3-\x3.\x3.\x3.\x3/\x3/\x3");
		sb.Append("/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x3\x30\x3");
		sb.Append("\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30");
		sb.Append("\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3");
		sb.Append("\x30\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31");
		sb.Append("\x3\x31\x3\x31\x3\x31\x3\x32\x3\x32\x3\x32\x3\x32\x3\x32\x3");
		sb.Append("\x33\x3\x33\x3\x33\x3\x33\a\x33\x14E\n\x33\f\x33\xE\x33\x151");
		sb.Append("\v\x33\x3\x33\x5\x33\x154\n\x33\x3\x33\x3\x33\x3\x33\x3\x33");
		sb.Append("\x3\x34\x3\x34\x3\x34\x3\x34\a\x34\x15E\n\x34\f\x34\xE\x34\x161");
		sb.Append("\v\x34\x3\x34\x3\x34\x3\x34\x3\x34\x3\x34\x3\x35\x6\x35\x169");
		sb.Append("\n\x35\r\x35\xE\x35\x16A\x3\x35\x3\x35\x3\x36\x3\x36\x3\x36");
		sb.Append("\x3\x36\x5\x36\x173\n\x36\x3\x37\x3\x37\x3\x37\a\x37\x178\n");
		sb.Append("\x37\f\x37\xE\x37\x17B\v\x37\x3\x38\x3\x38\a\x38\x17F\n\x38");
		sb.Append("\f\x38\xE\x38\x182\v\x38\x3\x38\x3\x38\x3\x38\a\x38\x187\n\x38");
		sb.Append("\f\x38\xE\x38\x18A\v\x38\x3\x38\x5\x38\x18D\n\x38\x3\x39\x3");
		sb.Append("\x39\x3\x39\x3\x39\x5\x39\x193\n\x39\x3:\x3:\x3:\x3:\x3;\x3");
		sb.Append(";\x3;\a;\x19C\n;\f;\xE;\x19F\v;\x3;\x3;\x3<\x3<\x3=\x6=\x1A6");
		sb.Append("\n=\r=\xE=\x1A7\x6\x14F\x15F\x188\x19D\x2>\x3\x3\x5\x4\a\x5");
		sb.Append("\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19\xE\x1B\xF\x1D");
		sb.Append("\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+\x17-\x18/\x19\x31\x1A");
		sb.Append("\x33\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F= ?!\x41\"\x43#\x45$G%");
		sb.Append("I&K\'M(O)Q*S+U,W-Y.[/]\x30_\x31\x61\x32\x63\x33\x65\x34g\x35");
		sb.Append("i\x36k\x2m\x37o\x38q\x2s\x39u:w\x2y;\x3\x2\x6\x5\x2\v\f\xF\xF");
		sb.Append("\"\"\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|");
		sb.Append("\x3\x2\x32;\x1B3\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3");
		sb.Append("\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2");
		sb.Append("\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2");
		sb.Append("\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B");
		sb.Append("\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2");
		sb.Append("\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)");
		sb.Append("\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2");
		sb.Append("\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2");
		sb.Append("\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2");
		sb.Append("\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2");
		sb.Append("\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2");
		sb.Append("\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3");
		sb.Append("\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x2");
		sb.Append("[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2\x2\x61\x3\x2\x2");
		sb.Append("\x2\x2\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2\x2\x2g\x3\x2\x2\x2\x2");
		sb.Append("i\x3\x2\x2\x2\x2m\x3\x2\x2\x2\x2o\x3\x2\x2\x2\x2s\x3\x2\x2\x2");
		sb.Append("\x2u\x3\x2\x2\x2\x2y\x3\x2\x2\x2\x3{\x3\x2\x2\x2\x5\x85\x3\x2");
		sb.Append("\x2\x2\a\x87\x3\x2\x2\x2\t\x89\x3\x2\x2\x2\v\x8E\x3\x2\x2\x2");
		sb.Append("\r\x90\x3\x2\x2\x2\xF\x92\x3\x2\x2\x2\x11\x94\x3\x2\x2\x2\x13");
		sb.Append("\x99\x3\x2\x2\x2\x15\x9F\x3\x2\x2\x2\x17\xA1\x3\x2\x2\x2\x19");
		sb.Append("\xA3\x3\x2\x2\x2\x1B\xA5\x3\x2\x2\x2\x1D\xA7\x3\x2\x2\x2\x1F");
		sb.Append("\xA9\x3\x2\x2\x2!\xAB\x3\x2\x2\x2#\xAD\x3\x2\x2\x2%\xB0\x3\x2");
		sb.Append("\x2\x2\'\xB3\x3\x2\x2\x2)\xB6\x3\x2\x2\x2+\xB9\x3\x2\x2\x2-");
		sb.Append("\xBC\x3\x2\x2\x2/\xBF\x3\x2\x2\x2\x31\xC2\x3\x2\x2\x2\x33\xC7");
		sb.Append("\x3\x2\x2\x2\x35\xCE\x3\x2\x2\x2\x37\xD2\x3\x2\x2\x2\x39\xD8");
		sb.Append("\x3\x2\x2\x2;\xDA\x3\x2\x2\x2=\xDC\x3\x2\x2\x2?\xDF\x3\x2\x2");
		sb.Append("\x2\x41\xE2\x3\x2\x2\x2\x43\xE4\x3\x2\x2\x2\x45\xE6\x3\x2\x2");
		sb.Append("\x2G\xE8\x3\x2\x2\x2I\xEA\x3\x2\x2\x2K\xEC\x3\x2\x2\x2M\xEF");
		sb.Append("\x3\x2\x2\x2O\xF2\x3\x2\x2\x2Q\xF4\x3\x2\x2\x2S\xF8\x3\x2\x2");
		sb.Append("\x2U\x101\x3\x2\x2\x2W\x108\x3\x2\x2\x2Y\x10D\x3\x2\x2\x2[\x114");
		sb.Append("\x3\x2\x2\x2]\x117\x3\x2\x2\x2_\x126\x3\x2\x2\x2\x61\x139\x3");
		sb.Append("\x2\x2\x2\x63\x144\x3\x2\x2\x2\x65\x149\x3\x2\x2\x2g\x159\x3");
		sb.Append("\x2\x2\x2i\x168\x3\x2\x2\x2k\x172\x3\x2\x2\x2m\x174\x3\x2\x2");
		sb.Append("\x2o\x18C\x3\x2\x2\x2q\x192\x3\x2\x2\x2s\x194\x3\x2\x2\x2u\x198");
		sb.Append("\x3\x2\x2\x2w\x1A2\x3\x2\x2\x2y\x1A5\x3\x2\x2\x2{|\aR\x2\x2");
		sb.Append("|}\ak\x2\x2}~\ag\x2\x2~\x7F\a\x65\x2\x2\x7F\x80\ag\x2\x2\x80");
		sb.Append("\x81\aV\x2\x2\x81\x82\a{\x2\x2\x82\x83\ar\x2\x2\x83\x84\ag\x2");
		sb.Append("\x2\x84\x4\x3\x2\x2\x2\x85\x86\a}\x2\x2\x86\x6\x3\x2\x2\x2\x87");
		sb.Append("\x88\a\x7F\x2\x2\x88\b\x3\x2\x2\x2\x89\x8A\aI\x2\x2\x8A\x8B");
		sb.Append("\a\x63\x2\x2\x8B\x8C\ao\x2\x2\x8C\x8D\ag\x2\x2\x8D\n\x3\x2\x2");
		sb.Append("\x2\x8E\x8F\a<\x2\x2\x8F\f\x3\x2\x2\x2\x90\x91\a?\x2\x2\x91");
		sb.Append("\xE\x3\x2\x2\x2\x92\x93\a=\x2\x2\x93\x10\x3\x2\x2\x2\x94\x95");
		sb.Append("\av\x2\x2\x95\x96\at\x2\x2\x96\x97\aw\x2\x2\x97\x98\ag\x2\x2");
		sb.Append("\x98\x12\x3\x2\x2\x2\x99\x9A\ah\x2\x2\x9A\x9B\a\x63\x2\x2\x9B");
		sb.Append("\x9C\an\x2\x2\x9C\x9D\au\x2\x2\x9D\x9E\ag\x2\x2\x9E\x14\x3\x2");
		sb.Append("\x2\x2\x9F\xA0\a*\x2\x2\xA0\x16\x3\x2\x2\x2\xA1\xA2\a+\x2\x2");
		sb.Append("\xA2\x18\x3\x2\x2\x2\xA3\xA4\a\x30\x2\x2\xA4\x1A\x3\x2\x2\x2");
		sb.Append("\xA5\xA6\a-\x2\x2\xA6\x1C\x3\x2\x2\x2\xA7\xA8\a/\x2\x2\xA8\x1E");
		sb.Append("\x3\x2\x2\x2\xA9\xAA\a>\x2\x2\xAA \x3\x2\x2\x2\xAB\xAC\a@\x2");
		sb.Append("\x2\xAC\"\x3\x2\x2\x2\xAD\xAE\a>\x2\x2\xAE\xAF\a?\x2\x2\xAF");
		sb.Append("$\x3\x2\x2\x2\xB0\xB1\a@\x2\x2\xB1\xB2\a?\x2\x2\xB2&\x3\x2\x2");
		sb.Append("\x2\xB3\xB4\a?\x2\x2\xB4\xB5\a?\x2\x2\xB5(\x3\x2\x2\x2\xB6\xB7");
		sb.Append("\a#\x2\x2\xB7\xB8\a?\x2\x2\xB8*\x3\x2\x2\x2\xB9\xBA\a(\x2\x2");
		sb.Append("\xBA\xBB\a(\x2\x2\xBB,\x3\x2\x2\x2\xBC\xBD\a~\x2\x2\xBD\xBE");
		sb.Append("\a~\x2\x2\xBE.\x3\x2\x2\x2\xBF\xC0\ak\x2\x2\xC0\xC1\ah\x2\x2");
		sb.Append("\xC1\x30\x3\x2\x2\x2\xC2\xC3\ag\x2\x2\xC3\xC4\an\x2\x2\xC4\xC5");
		sb.Append("\au\x2\x2\xC5\xC6\ag\x2\x2\xC6\x32\x3\x2\x2\x2\xC7\xC8\at\x2");
		sb.Append("\x2\xC8\xC9\ag\x2\x2\xC9\xCA\av\x2\x2\xCA\xCB\aw\x2\x2\xCB\xCC");
		sb.Append("\at\x2\x2\xCC\xCD\ap\x2\x2\xCD\x34\x3\x2\x2\x2\xCE\xCF\ax\x2");
		sb.Append("\x2\xCF\xD0\a\x63\x2\x2\xD0\xD1\at\x2\x2\xD1\x36\x3\x2\x2\x2");
		sb.Append("\xD2\xD3\an\x2\x2\xD3\xD4\aq\x2\x2\xD4\xD5\a\x65\x2\x2\xD5\xD6");
		sb.Append("\a\x63\x2\x2\xD6\xD7\an\x2\x2\xD7\x38\x3\x2\x2\x2\xD8\xD9\a");
		sb.Append("]\x2\x2\xD9:\x3\x2\x2\x2\xDA\xDB\a_\x2\x2\xDB<\x3\x2\x2\x2\xDC");
		sb.Append("\xDD\a-\x2\x2\xDD\xDE\a-\x2\x2\xDE>\x3\x2\x2\x2\xDF\xE0\a/\x2");
		sb.Append("\x2\xE0\xE1\a/\x2\x2\xE1@\x3\x2\x2\x2\xE2\xE3\a#\x2\x2\xE3\x42");
		sb.Append("\x3\x2\x2\x2\xE4\xE5\a,\x2\x2\xE5\x44\x3\x2\x2\x2\xE6\xE7\a");
		sb.Append("\x31\x2\x2\xE7\x46\x3\x2\x2\x2\xE8\xE9\a\'\x2\x2\xE9H\x3\x2");
		sb.Append("\x2\x2\xEA\xEB\a\x41\x2\x2\xEBJ\x3\x2\x2\x2\xEC\xED\a-\x2\x2");
		sb.Append("\xED\xEE\a?\x2\x2\xEEL\x3\x2\x2\x2\xEF\xF0\a/\x2\x2\xF0\xF1");
		sb.Append("\a?\x2\x2\xF1N\x3\x2\x2\x2\xF2\xF3\a.\x2\x2\xF3P\x3\x2\x2\x2");
		sb.Append("\xF4\xF5\aK\x2\x2\xF5\xF6\ap\x2\x2\xF6\xF7\av\x2\x2\xF7R\x3");
		sb.Append("\x2\x2\x2\xF8\xF9\aK\x2\x2\xF9\xFA\ap\x2\x2\xFA\xFB\av\x2\x2");
		sb.Append("\xFB\xFC\aT\x2\x2\xFC\xFD\a\x63\x2\x2\xFD\xFE\ap\x2\x2\xFE\xFF");
		sb.Append("\ai\x2\x2\xFF\x100\ag\x2\x2\x100T\x3\x2\x2\x2\x101\x102\aU\x2");
		sb.Append("\x2\x102\x103\av\x2\x2\x103\x104\at\x2\x2\x104\x105\ak\x2\x2");
		sb.Append("\x105\x106\ap\x2\x2\x106\x107\ai\x2\x2\x107V\x3\x2\x2\x2\x108");
		sb.Append("\x109\a\x44\x2\x2\x109\x10A\aq\x2\x2\x10A\x10B\aq\x2\x2\x10B");
		sb.Append("\x10C\an\x2\x2\x10CX\x3\x2\x2\x2\x10D\x10E\a\x45\x2\x2\x10E");
		sb.Append("\x10F\aj\x2\x2\x10F\x110\aq\x2\x2\x110\x111\ak\x2\x2\x111\x112");
		sb.Append("\a\x65\x2\x2\x112\x113\ag\x2\x2\x113Z\x3\x2\x2\x2\x114\x115");
		sb.Append("\a\x30\x2\x2\x115\x116\a\x30\x2\x2\x116\\\x3\x2\x2\x2\x117\x118");
		sb.Append("\aO\x2\x2\x118\x119\ak\x2\x2\x119\x11A\at\x2\x2\x11A\x11B\a");
		sb.Append("t\x2\x2\x11B\x11C\aq\x2\x2\x11C\x11D\at\x2\x2\x11D\x11E\aU\x2");
		sb.Append("\x2\x11E\x11F\a{\x2\x2\x11F\x120\ao\x2\x2\x120\x121\ao\x2\x2");
		sb.Append("\x121\x122\ag\x2\x2\x122\x123\av\x2\x2\x123\x124\at\x2\x2\x124");
		sb.Append("\x125\a{\x2\x2\x125^\x3\x2\x2\x2\x126\x127\aT\x2\x2\x127\x128");
		sb.Append("\aq\x2\x2\x128\x129\av\x2\x2\x129\x12A\a\x63\x2\x2\x12A\x12B");
		sb.Append("\av\x2\x2\x12B\x12C\ak\x2\x2\x12C\x12D\aq\x2\x2\x12D\x12E\a");
		sb.Append("p\x2\x2\x12E\x12F\a\x63\x2\x2\x12F\x130\an\x2\x2\x130\x131\a");
		sb.Append("U\x2\x2\x131\x132\a{\x2\x2\x132\x133\ao\x2\x2\x133\x134\ao\x2");
		sb.Append("\x2\x134\x135\ag\x2\x2\x135\x136\av\x2\x2\x136\x137\at\x2\x2");
		sb.Append("\x137\x138\a{\x2\x2\x138`\x3\x2\x2\x2\x139\x13A\aP\x2\x2\x13A");
		sb.Append("\x13B\aq\x2\x2\x13B\x13C\aU\x2\x2\x13C\x13D\a{\x2\x2\x13D\x13E");
		sb.Append("\ao\x2\x2\x13E\x13F\ao\x2\x2\x13F\x140\ag\x2\x2\x140\x141\a");
		sb.Append("v\x2\x2\x141\x142\at\x2\x2\x142\x143\a{\x2\x2\x143\x62\x3\x2");
		sb.Append("\x2\x2\x144\x145\ap\x2\x2\x145\x146\aw\x2\x2\x146\x147\an\x2");
		sb.Append("\x2\x147\x148\an\x2\x2\x148\x64\x3\x2\x2\x2\x149\x14A\a\x31");
		sb.Append("\x2\x2\x14A\x14B\a\x31\x2\x2\x14B\x14F\x3\x2\x2\x2\x14C\x14E");
		sb.Append("\v\x2\x2\x2\x14D\x14C\x3\x2\x2\x2\x14E\x151\x3\x2\x2\x2\x14F");
		sb.Append("\x150\x3\x2\x2\x2\x14F\x14D\x3\x2\x2\x2\x150\x153\x3\x2\x2\x2");
		sb.Append("\x151\x14F\x3\x2\x2\x2\x152\x154\a\xF\x2\x2\x153\x152\x3\x2");
		sb.Append("\x2\x2\x153\x154\x3\x2\x2\x2\x154\x155\x3\x2\x2\x2\x155\x156");
		sb.Append("\a\f\x2\x2\x156\x157\x3\x2\x2\x2\x157\x158\b\x33\x2\x2\x158");
		sb.Append("\x66\x3\x2\x2\x2\x159\x15A\a\x31\x2\x2\x15A\x15B\a,\x2\x2\x15B");
		sb.Append("\x15F\x3\x2\x2\x2\x15C\x15E\v\x2\x2\x2\x15D\x15C\x3\x2\x2\x2");
		sb.Append("\x15E\x161\x3\x2\x2\x2\x15F\x160\x3\x2\x2\x2\x15F\x15D\x3\x2");
		sb.Append("\x2\x2\x160\x162\x3\x2\x2\x2\x161\x15F\x3\x2\x2\x2\x162\x163");
		sb.Append("\a,\x2\x2\x163\x164\a\x31\x2\x2\x164\x165\x3\x2\x2\x2\x165\x166");
		sb.Append("\b\x34\x2\x2\x166h\x3\x2\x2\x2\x167\x169\t\x2\x2\x2\x168\x167");
		sb.Append("\x3\x2\x2\x2\x169\x16A\x3\x2\x2\x2\x16A\x168\x3\x2\x2\x2\x16A");
		sb.Append("\x16B\x3\x2\x2\x2\x16B\x16C\x3\x2\x2\x2\x16C\x16D\b\x35\x3\x2");
		sb.Append("\x16Dj\x3\x2\x2\x2\x16E\x16F\a^\x2\x2\x16F\x173\a$\x2\x2\x170");
		sb.Append("\x171\a^\x2\x2\x171\x173\a^\x2\x2\x172\x16E\x3\x2\x2\x2\x172");
		sb.Append("\x170\x3\x2\x2\x2\x173l\x3\x2\x2\x2\x174\x175\a\x42\x2\x2\x175");
		sb.Append("\x179\t\x3\x2\x2\x176\x178\t\x4\x2\x2\x177\x176\x3\x2\x2\x2");
		sb.Append("\x178\x17B\x3\x2\x2\x2\x179\x177\x3\x2\x2\x2\x179\x17A\x3\x2");
		sb.Append("\x2\x2\x17An\x3\x2\x2\x2\x17B\x179\x3\x2\x2\x2\x17C\x180\t\x3");
		sb.Append("\x2\x2\x17D\x17F\t\x4\x2\x2\x17E\x17D\x3\x2\x2\x2\x17F\x182");
		sb.Append("\x3\x2\x2\x2\x180\x17E\x3\x2\x2\x2\x180\x181\x3\x2\x2\x2\x181");
		sb.Append("\x18D\x3\x2\x2\x2\x182\x180\x3\x2\x2\x2\x183\x188\a)\x2\x2\x184");
		sb.Append("\x187\x5q\x39\x2\x185\x187\v\x2\x2\x2\x186\x184\x3\x2\x2\x2");
		sb.Append("\x186\x185\x3\x2\x2\x2\x187\x18A\x3\x2\x2\x2\x188\x189\x3\x2");
		sb.Append("\x2\x2\x188\x186\x3\x2\x2\x2\x189\x18B\x3\x2\x2\x2\x18A\x188");
		sb.Append("\x3\x2\x2\x2\x18B\x18D\a)\x2\x2\x18C\x17C\x3\x2\x2\x2\x18C\x183");
		sb.Append("\x3\x2\x2\x2\x18Dp\x3\x2\x2\x2\x18E\x18F\a^\x2\x2\x18F\x193");
		sb.Append("\a)\x2\x2\x190\x191\a^\x2\x2\x191\x193\a^\x2\x2\x192\x18E\x3");
		sb.Append("\x2\x2\x2\x192\x190\x3\x2\x2\x2\x193r\x3\x2\x2\x2\x194\x195");
		sb.Append("\a\x62\x2\x2\x195\x196\v\x2\x2\x2\x196\x197\a\x62\x2\x2\x197");
		sb.Append("t\x3\x2\x2\x2\x198\x19D\a$\x2\x2\x199\x19C\x5k\x36\x2\x19A\x19C");
		sb.Append("\v\x2\x2\x2\x19B\x199\x3\x2\x2\x2\x19B\x19A\x3\x2\x2\x2\x19C");
		sb.Append("\x19F\x3\x2\x2\x2\x19D\x19E\x3\x2\x2\x2\x19D\x19B\x3\x2\x2\x2");
		sb.Append("\x19E\x1A0\x3\x2\x2\x2\x19F\x19D\x3\x2\x2\x2\x1A0\x1A1\a$\x2");
		sb.Append("\x2\x1A1v\x3\x2\x2\x2\x1A2\x1A3\t\x5\x2\x2\x1A3x\x3\x2\x2\x2");
		sb.Append("\x1A4\x1A6\x5w<\x2\x1A5\x1A4\x3\x2\x2\x2\x1A6\x1A7\x3\x2\x2");
		sb.Append("\x2\x1A7\x1A5\x3\x2\x2\x2\x1A7\x1A8\x3\x2\x2\x2\x1A8z\x3\x2");
		sb.Append("\x2\x2\x11\x2\x14F\x153\x15F\x16A\x172\x179\x180\x186\x188\x18C");
		sb.Append("\x192\x19B\x19D\x1A7\x4\x2\x3\x2\b\x2\x2");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}