// Signature file for parser generated by fsyacc
module SyntaxHighlighting.FsParser
type token = 
  | EOF
  | GHOST of (Position*Position)
  | GUARDED of (Position*Position)
  | KEYWORD of (Position*Position)
  | RPAREN of (Position)
  | LPAREN of (Position)
  | OPENSPEC of (Position)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_GHOST
    | TOKEN_GUARDED
    | TOKEN_KEYWORD
    | TOKEN_RPAREN
    | TOKEN_LPAREN
    | TOKEN_OPENSPEC
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_Program
    | NONTERM_NestedParens
    | NONTERM_Parens
    | NONTERM_NestedParensInSpec
    | NONTERM_ParensInSpec
    | NONTERM_IgnoredKeywords
    | NONTERM_Keywords
    | NONTERM_KeywordOpt
/// This function maps integers indexes to symbolic token ids
val tagOfToken: token -> int

/// This function maps integers indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( unit ) 