
// SlkConstants.h - generated by the SLK parser generator 

#ifndef _SlkCONSTANTS_H
#define _SlkCONSTANTS_H

enum _Slk_token_defines { 
  OP_TOKEN_0_ = 1 
, OP_TOKEN_1_ = 2 
, OP_TOKEN_2_ = 3 
, OP_TOKEN_COLON_ = 4 
, OP_TOKEN_QUESTION_ = 5 
, OP_TOKEN_3_ = 6 
, OP_TOKEN_4_ = 7 
, OP_TOKEN_5_ = 8 
, OP_TOKEN_6_ = 9 
, OP_TOKEN_7_ = 10 
, OP_TOKEN_8_ = 11 
, OP_TOKEN_9_ = 12 
, OP_TOKEN_10_ = 13 
, OP_TOKEN_11_ = 14 
, OP_TOKEN_12_ = 15 
, OP_TOKEN_13_ = 16 
, OP_TOKEN_14_ = 17 
, OP_TOKEN_15_ = 18 
, LPAREN_ = 19 
, RPAREN_ = 20 
, LBRACK_ = 21 
, RBRACK_ = 22 
, COLON_COLON_ = 23 
, DOT_ = 24 
, QUESTION_PERIOD_ = 25 
, QUESTION_PARENTHESIS_ = 26 
, QUESTION_BRACKET_ = 27 
, QUESTION_BRACE_ = 28 
, RBRACE_ = 29 
, POINTER_ = 30 
, PERIOD_STAR_ = 31 
, QUESTION_PERIOD_STAR_ = 32 
, POINTER_STAR_ = 33 
, LBRACE_ = 34 
, SCRIPT_CONTENT_ = 35 
, BRACKET_COLON_BEGIN_ = 36 
, BRACKET_COLON_END_ = 37 
, PARENTHESIS_COLON_BEGIN_ = 38 
, PARENTHESIS_COLON_END_ = 39 
, ANGLE_BRACKET_COLON_BEGIN_ = 40 
, ANGLE_BRACKET_COLON_END_ = 41 
, BRACE_PERCENT_BEGIN_ = 42 
, BRACE_PERCENT_END_ = 43 
, BRACKET_PERCENT_BEGIN_ = 44 
, BRACKET_PERCENT_END_ = 45 
, PARENTHESIS_PERCENT_BEGIN_ = 46 
, PARENTHESIS_PERCENT_END_ = 47 
, ANGLE_BRACKET_PERCENT_BEGIN_ = 48 
, ANGLE_BRACKET_PERCENT_END_ = 49 
, IDENTIFIER_ = 50 
, STRING_ = 51 
, NUMBER_ = 52 
, COMMA_ = 53 
, SEMI_ = 54 
, END_OF_SLK_INPUT_ = 55 
}; 

enum _Slk_Nonterminal_defines { 
  NT_PROGRAM_ = 56 
, NT_STATEMENTS_ = 57 
, NT_STATEMENT_ = 58 
, NT_OPERATOR_STATEMENT_1_ = 59 
, NT_OPERATOR_STATEMENT_2_ = 60 
, NT_OPERATOR_STATEMENT_COLON_ = 61 
, NT_OPERATOR_STATEMENT_QUESTION_COLON_ = 62 
, NT_OPERATOR_STATEMENT_3_ = 63 
, NT_OPERATOR_STATEMENT_4_ = 64 
, NT_OPERATOR_STATEMENT_5_ = 65 
, NT_OPERATOR_STATEMENT_6_ = 66 
, NT_OPERATOR_STATEMENT_7_ = 67 
, NT_OPERATOR_STATEMENT_8_ = 68 
, NT_OPERATOR_STATEMENT_9_ = 69 
, NT_OPERATOR_STATEMENT_10_ = 70 
, NT_OPERATOR_STATEMENT_11_ = 71 
, NT_OPERATOR_STATEMENT_12_ = 72 
, NT_OPERATOR_STATEMENT_13_ = 73 
, NT_OPERATOR_STATEMENT_14_ = 74 
, NT_OPERATOR_STATEMENT_15_ = 75 
, NT_OPERATOR_STATEMENT_DESC_0_ = 76 
, NT_OPERATOR_STATEMENT_DESC_1_ = 77 
, NT_OPERATOR_STATEMENT_DESC_2_ = 78 
, NT_OPERATOR_STATEMENT_DESC_COLON_ = 79 
, NT_OPERATOR_STATEMENT_DESC_QUESTION_COLON_ = 80 
, NT_OPERATOR_STATEMENT_DESC_3_ = 81 
, NT_OPERATOR_STATEMENT_DESC_4_ = 82 
, NT_OPERATOR_STATEMENT_DESC_5_ = 83 
, NT_OPERATOR_STATEMENT_DESC_6_ = 84 
, NT_OPERATOR_STATEMENT_DESC_7_ = 85 
, NT_OPERATOR_STATEMENT_DESC_8_ = 86 
, NT_OPERATOR_STATEMENT_DESC_9_ = 87 
, NT_OPERATOR_STATEMENT_DESC_10_ = 88 
, NT_OPERATOR_STATEMENT_DESC_11_ = 89 
, NT_OPERATOR_STATEMENT_DESC_12_ = 90 
, NT_OPERATOR_STATEMENT_DESC_13_ = 91 
, NT_OPERATOR_STATEMENT_DESC_14_ = 92 
, NT_OPERATOR_STATEMENT_DESC_15_ = 93 
, NT_FUNCTION_STATEMENT_ = 94 
, NT_FUNCTION_STATEMENT_DESC_ = 95 
, NT_FUNCTION_CALLS_ = 96 
, NT_FUNCTION_EX_CALL_ = 97 
, NT_FUNCTION_EX_CALL_SPECIAL_ = 98 
, NT_FUNCTION_PARAMS_ = 99 
, NT_STATIC_MEMBER_DESC_ = 100 
, NT_MEMBER_DESC_ = 101 
, NT_MEMBER_DESC2_ = 102 
, NT_MEMBER_DESC3_ = 103 
, NT_MEMBER_DESC4_ = 104 
, NT_MEMBER_DESC5_ = 105 
, NT_MEMBER_DESC6_ = 106 
, NT_FUNCTION_ID_ = 107 
, NT_SEP_ = 108 
, NT_SEP_STATEMENT_STAR_ = 109 
, NT_OP_TOKEN_0_OPERATOR_STATEMENT_1_STAR_ = 110 
, NT_OP_TOKEN_1_OPERATOR_STATEMENT_2_STAR_ = 111 
, NT_OP_TOKEN_2_OPERATOR_STATEMENT_COLON_STAR_ = 112 
, NT_OP_TOKEN_COLON_OPERATOR_STATEMENT_QUESTION_COLON_STAR_ = 113 
, NT_OP_TOKEN_QUESTION_OPERATOR_STATEMENT_3_OP_TOKEN_COLON_OPERATOR_STATEMENT_3_STAR_ = 114 
, NT_OP_TOKEN_3_OPERATOR_STATEMENT_4_STAR_ = 115 
, NT_OP_TOKEN_4_OPERATOR_STATEMENT_5_STAR_ = 116 
, NT_OP_TOKEN_5_OPERATOR_STATEMENT_6_STAR_ = 117 
, NT_OP_TOKEN_6_OPERATOR_STATEMENT_7_STAR_ = 118 
, NT_OP_TOKEN_7_OPERATOR_STATEMENT_8_STAR_ = 119 
, NT_OP_TOKEN_8_OPERATOR_STATEMENT_9_STAR_ = 120 
, NT_OP_TOKEN_9_OPERATOR_STATEMENT_10_STAR_ = 121 
, NT_OP_TOKEN_10_OPERATOR_STATEMENT_11_STAR_ = 122 
, NT_OP_TOKEN_11_OPERATOR_STATEMENT_12_STAR_ = 123 
, NT_OP_TOKEN_12_OPERATOR_STATEMENT_13_STAR_ = 124 
, NT_OP_TOKEN_13_OPERATOR_STATEMENT_14_STAR_ = 125 
, NT_OP_TOKEN_14_OPERATOR_STATEMENT_15_STAR_ = 126 
, NT_OP_TOKEN_15_FUNCTION_STATEMENT_STAR_ = 127 
, NT_FUNCTION_EX_CALL_STAR_ = 128 
, NT_FUNCTION_EX_CALL_2_STAR_ = 129 
, NT_FUNCTION_PARAMS_OPT_ = 130 
, NT_FUNCTION_PARAMS_2_OPT_ = 131 
, NT_FUNCTION_PARAMS_3_OPT_ = 132 
, NT_FUNCTION_PARAMS_4_OPT_ = 133 
, NT_FUNCTION_PARAMS_5_OPT_ = 134 
, NT_FUNCTION_PARAMS_6_OPT_ = 135 
, NT_FUNCTION_PARAMS_7_OPT_ = 136 
, NT_FUNCTION_PARAMS_8_OPT_ = 137 
, NT_FUNCTION_PARAMS_9_OPT_ = 138 
, NT_FUNCTION_PARAMS_10_OPT_ = 139 
, NT_FUNCTION_PARAMS_11_OPT_ = 140 
, NT_FUNCTION_PARAMS_12_OPT_ = 141 
, NT_FUNCTION_PARAMS_13_OPT_ = 142 
, NT_FUNCTION_PARAMS_14_OPT_ = 143 
, NT_FUNCTION_PARAMS_15_OPT_ = 144 
, NT_FUNCTION_PARAMS_16_OPT_ = 145 
, NT_FUNCTION_PARAMS_17_OPT_ = 146 
, NT_FUNCTION_PARAMS_18_OPT_ = 147 
, NT_FUNCTION_PARAMS_19_OPT_ = 148 
, NT_FUNCTION_PARAMS_20_OPT_ = 149 
, NT_FUNCTION_PARAMS_21_OPT_ = 150 
, NT_FUNCTION_PARAMS_22_OPT_ = 151 
}; 

typedef unsigned short   slk_size_t;

#define NOT_A_SYMBOL       0
#define NONTERMINAL_SYMBOL 1
#define TERMINAL_SYMBOL    2
#define ACTION_SYMBOL      3

int SlkGetSymbolType ( slk_size_t symbol );
slk_size_t *SlkGetProductionArray ( slk_size_t   production_number );
slk_size_t *SlkGetState ( slk_size_t  state_number );
int SlkIsNonterminal ( slk_size_t symbol );
int SlkIsTerminal ( slk_size_t symbol );
int SlkIsAction ( slk_size_t symbol );


#endif
