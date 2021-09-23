
// LuaString.cs - generated by the SLK parser generator 

namespace Dsl.LuaParser {

class LuaString {

private static string[] Nonterminal_name ={"0"

,"CHUNK"
,"BLOCK"
,"STAT_UNAMBIGUOUS_GROUP"
,"STAT_UNAMBIGUOUS_OR_SEP"
,"EXP_TAIL"
,"EXP_TAIL_FUNCTION_CALL_STAT"
,"EXP_TAIL_FUNCTION_CALL_STAT_TAIL"
,"STAT_UNAMBIGUOUS"
,"FUNCTION_CALL_STAT"
,"FUNCTION_CALL_STAT_TAIL"
,"FUNCTIONDEF_OR_VARDEF"
,"END_VARDEF"
,"FOR_TAIL"
,"ATTNAMELIST"
,"NAME_AND_ATTRIB"
,"ATTRIB"
,"RETURN_STAT"
,"RETSTAT"
,"LABEL"
,"FUNCNAME"
,"NAME_FOR_ARG"
,"DOT_FOR_FUNCNAME"
,"COLON_FOR_FUNCNAME"
,"FUNCTIONDEF"
,"FUNCBODY"
,"PARLIST"
,"THREE_DOT_FOR_ARG"
,"PARLIST_TAIL"
,"EXPLIST"
,"EXP"
,"EXP_1"
,"EXP_2"
,"EXP_3"
,"EXP_4"
,"EXP_5"
,"EXP_6"
,"EXP_7"
,"EXP_8"
,"EXP_9"
,"EXP_10"
,"EXP_11"
,"EXP_12"
,"FUNCTION_CALL"
,"VALUE_JUST_AS_FUNCTION"
,"FUNCTION_CALL_WITH_NAME"
,"FUNCTION_CALL_WITHOUT_NAME"
,"FUNCTION_PARAMS_CANBE_HEADER"
,"FUNCTION_PARAMS"
,"MEMBER_DESC"
,"MEMBER_DESC2"
,"FIELD_LIST"
,"FIELD_LIST_TAIL"
,"FIELD"
,"FIELD_EXP"
,"FUNCTION_CALL_WITHOUT_NAME_OP"
,"FIELD_NAME_TAIL"
,"FUNCTION_CALL_AFTER_ID"
,"FIELD_SEP"
,"FUNCTION_ID"
,"FUNCTION_ID_NOT_NAME"
,"STAT_UNAMBIGUOUS_GROUP_*"
,"RETURN_STAT_opt"
,",_FUNCTION_CALL_*"
,"ELSEIF_EXP_THEN_BLOCK_*"
,"ELSE_BLOCK_opt"
,",_FUNCTION_CALL_2_*"
,"=_EXPLIST_opt"
,",_EXP_opt"
,",_NAME_FOR_ARG_*"
,",_NAME_AND_ATTRIB_*"
,"<_NAME_FOR_ARG_>_opt"
,"EXPLIST_opt"
,";_opt"
,"DOT_FOR_FUNCNAME_NAME_FOR_ARG_*"
,"COLON_FOR_FUNCNAME_NAME_FOR_ARG_opt"
,"PARLIST_opt"
,"PARLIST_TAIL_opt"
,",_EXP_*"
,"OP_1_EXP_2_*"
,"OP_2_EXP_3_*"
,"OP_3_EXP_4_*"
,"OP_4_EXP_5_*"
,"OP_5_EXP_6_*"
,"OP_6_EXP_7_*"
,"OP_7_EXP_8_*"
,"OP_8_EXP_9_*"
,"OP_9_EXP_10_*"
,"OP_10_EXP_11_*"
,"OP_12_FUNCTION_CALL_*"
,"FUNCTION_PARAMS_opt"
,"EXPLIST_2_opt"
,"FUNCTION_PARAMS_2_opt"
,"FIELD_LIST_opt"
,"FUNCTION_PARAMS_3_opt"
,"FUNCTION_PARAMS_4_opt"
,"FUNCTION_PARAMS_5_opt"
,"FUNCTION_PARAMS_6_opt"
,"FUNCTION_PARAMS_7_opt"
,"FIELD_LIST_TAIL_opt"
,"FIELD_LIST_2_opt"
,"OP_1_EXP_2_2_*"
,"FUNCTION_PARAMS_8_opt"
,"OP_1_EXP_2_3_*"
};

private static string[] Terminal_name ={"0"

,"REPEAT"
,"UNTIL"
,"LOCAL"
,";"
,","
,"="
,"BREAK"
,"GOTO"
,"DO"
,"END"
,"WHILE"
,"IF"
,"THEN"
,"ELSEIF"
,"ELSE"
,"FOR"
,"FUNCTION"
,"IN"
,"<"
,">"
,"RETURN"
,"TWO_COLON"
,"NAME"
,"."
,":"
,"("
,")"
,"THREE_DOT"
,"OP_1"
,"OP_2"
,"OP_3"
,"OP_4"
,"OP_5"
,"OP_6"
,"OP_7"
,"OP_8"
,"OP_9"
,"OP_10"
,"OP_11"
,"OP_12"
,"{"
,"}"
,"["
,"]"
,"STRING"
,"NUMBER"
,"TRUE"
,"FALSE"
,"NIL"
,"END_OF_SLK_INPUT"
};

private static string[] Action_name ={"0"

,"_action_beginStatement"
,"_action_addFunction"
,"_action_pushId"
,"_action_setFunctionId"
,"_action_markStatement"
,"_action_markParenthesisParam"
,"_action_endStatement"
,"_action_pushLuaList"
,"_action_checkLuaList"
,"_action_pushAssignWith"
,"_action_removeLuaList"
,"_action_pushLuaLabel"
,"_action_buildHighOrderFunction"
,"_action_pushLuaRange"
,"_action_pushLuaVarAttr"
,"_action_markBracketAttrParam"
,"_action_removeLuaVarAttr"
,"_action_markParenthesisAttrParam"
,"_action_pushDot"
,"_action_pushColon"
,"_action_pushLuaArgs"
,"_action_buildOperator"
,"_action_markBracketParam"
,"_action_markParenthesisColonParam"
,"_action_markPeriodParam"
,"_action_setMemberId"
,"_action_markPointerParam"
,"_action_pushStr"
,"_action_pushNum"
};

private static string[] Production_name ={"0"

,"CHUNK --> BLOCK"
,"BLOCK --> STAT_UNAMBIGUOUS_GROUP_* RETURN_STAT_opt"
,"STAT_UNAMBIGUOUS_GROUP --> FUNCTION_CALL_STAT"
,"STAT_UNAMBIGUOUS_GROUP --> STAT_UNAMBIGUOUS_OR_SEP"
,"STAT_UNAMBIGUOUS_OR_SEP --> _action_beginStatement _action_addFunction REPEAT _action_pushId _action_setFunctionId _action_markStatement BLOCK _action_addFunction UNTIL _action_pushId _action_setFunctionId _action_markParenthesisParam EXP _action_endStatement EXP_TAIL"
,"STAT_UNAMBIGUOUS_OR_SEP --> _action_beginStatement _action_addFunction LOCAL _action_pushId _action_setFunctionId _action_markParenthesisParam FUNCTIONDEF_OR_VARDEF"
,"STAT_UNAMBIGUOUS_OR_SEP --> STAT_UNAMBIGUOUS"
,"STAT_UNAMBIGUOUS_OR_SEP --> ;"
,"EXP_TAIL --> EXP_TAIL_FUNCTION_CALL_STAT EXP_TAIL"
,"EXP_TAIL --> STAT_UNAMBIGUOUS_OR_SEP"
,"EXP_TAIL_FUNCTION_CALL_STAT --> _action_beginStatement _action_addFunction _action_pushLuaList _action_setFunctionId _action_markParenthesisParam _action_beginStatement FUNCTION_CALL_WITH_NAME _action_endStatement EXP_TAIL_FUNCTION_CALL_STAT_TAIL"
,"EXP_TAIL_FUNCTION_CALL_STAT_TAIL --> ,_FUNCTION_CALL_* = _action_checkLuaList _action_addFunction _action_pushAssignWith _action_setFunctionId _action_markParenthesisParam EXPLIST _action_endStatement"
,"EXP_TAIL_FUNCTION_CALL_STAT_TAIL --> _action_removeLuaList"
,"STAT_UNAMBIGUOUS --> _action_beginStatement _action_addFunction _action_pushLuaLabel _action_setFunctionId LABEL _action_endStatement"
,"STAT_UNAMBIGUOUS --> _action_beginStatement _action_addFunction BREAK _action_pushId _action_setFunctionId _action_endStatement"
,"STAT_UNAMBIGUOUS --> _action_beginStatement _action_addFunction GOTO _action_pushId _action_setFunctionId _action_markParenthesisParam NAME_FOR_ARG _action_endStatement"
,"STAT_UNAMBIGUOUS --> _action_beginStatement _action_addFunction DO _action_pushId _action_setFunctionId _action_markStatement BLOCK END _action_endStatement"
,"STAT_UNAMBIGUOUS --> _action_beginStatement _action_addFunction WHILE _action_pushId _action_setFunctionId _action_markParenthesisParam EXP DO _action_buildHighOrderFunction _action_markStatement BLOCK END _action_endStatement"
,"STAT_UNAMBIGUOUS --> _action_beginStatement _action_addFunction IF _action_pushId _action_setFunctionId _action_markParenthesisParam EXP THEN _action_buildHighOrderFunction _action_markStatement BLOCK ELSEIF_EXP_THEN_BLOCK_* ELSE_BLOCK_opt END _action_endStatement"
,"STAT_UNAMBIGUOUS --> _action_beginStatement _action_addFunction FOR _action_pushId _action_setFunctionId _action_markParenthesisParam NAME_FOR_ARG FOR_TAIL _action_endStatement"
,"STAT_UNAMBIGUOUS --> _action_beginStatement _action_addFunction FUNCTION _action_pushId _action_setFunctionId _action_markParenthesisParam FUNCNAME _action_addFunction FUNCBODY _action_endStatement"
,"FUNCTION_CALL_STAT --> _action_beginStatement _action_addFunction _action_pushLuaList _action_setFunctionId _action_markParenthesisParam _action_beginStatement FUNCTION_CALL _action_endStatement FUNCTION_CALL_STAT_TAIL"
,"FUNCTION_CALL_STAT_TAIL --> ,_FUNCTION_CALL_2_* = _action_checkLuaList _action_addFunction _action_pushAssignWith _action_setFunctionId _action_markParenthesisParam EXPLIST _action_endStatement EXP_TAIL"
,"FUNCTION_CALL_STAT_TAIL --> _action_removeLuaList EXP_TAIL"
,"FUNCTIONDEF_OR_VARDEF --> _action_beginStatement _action_addFunction FUNCTION _action_pushId _action_setFunctionId _action_markParenthesisParam NAME_FOR_ARG _action_addFunction FUNCBODY _action_endStatement _action_endStatement"
,"FUNCTIONDEF_OR_VARDEF --> _action_beginStatement _action_addFunction _action_pushLuaList _action_setFunctionId _action_markParenthesisParam ATTNAMELIST =_EXPLIST_opt END_VARDEF EXP_TAIL"
,"END_VARDEF --> _action_endStatement"
,"FOR_TAIL --> = _action_addFunction _action_pushLuaRange _action_setFunctionId _action_markParenthesisParam EXP , EXP ,_EXP_opt DO _action_buildHighOrderFunction _action_markStatement BLOCK END"
,"FOR_TAIL --> ,_NAME_FOR_ARG_* IN _action_pushId _action_setFunctionId _action_markParenthesisParam EXPLIST DO _action_buildHighOrderFunction _action_markStatement BLOCK END"
,"ATTNAMELIST --> NAME_AND_ATTRIB ,_NAME_AND_ATTRIB_*"
,"NAME_AND_ATTRIB --> _action_beginStatement _action_addFunction _action_pushLuaVarAttr _action_setFunctionId _action_markParenthesisParam NAME_FOR_ARG ATTRIB"
,"ATTRIB --> <_NAME_FOR_ARG_>_opt"
,"RETURN_STAT --> RETSTAT _action_endStatement"
,"RETSTAT --> _action_beginStatement _action_addFunction RETURN _action_pushId _action_setFunctionId _action_markParenthesisParam EXPLIST_opt ;_opt"
,"LABEL --> TWO_COLON _action_markParenthesisAttrParam NAME_FOR_ARG TWO_COLON"
,"FUNCNAME --> NAME_FOR_ARG DOT_FOR_FUNCNAME_NAME_FOR_ARG_* COLON_FOR_FUNCNAME_NAME_FOR_ARG_opt"
,"NAME_FOR_ARG --> _action_beginStatement _action_addFunction NAME _action_pushId _action_setFunctionId _action_endStatement"
,"DOT_FOR_FUNCNAME --> _action_beginStatement _action_addFunction . _action_pushDot _action_setFunctionId _action_endStatement"
,"COLON_FOR_FUNCNAME --> _action_beginStatement _action_addFunction : _action_pushColon _action_setFunctionId _action_endStatement"
,"FUNCTIONDEF --> _action_beginStatement _action_addFunction FUNCTION _action_pushId _action_setFunctionId _action_markParenthesisParam _action_addFunction FUNCBODY _action_endStatement"
,"FUNCBODY --> _action_pushLuaArgs _action_setFunctionId _action_markParenthesisParam ( PARLIST_opt ) _action_buildHighOrderFunction _action_markStatement BLOCK END"
,"PARLIST --> NAME_FOR_ARG PARLIST_TAIL_opt"
,"PARLIST --> THREE_DOT_FOR_ARG"
,"THREE_DOT_FOR_ARG --> _action_beginStatement _action_addFunction THREE_DOT _action_pushId _action_setFunctionId _action_endStatement"
,"PARLIST_TAIL --> , PARLIST"
,"EXPLIST --> EXP ,_EXP_*"
,"EXP --> EXP_1 _action_endStatement"
,"EXP --> FUNCTIONDEF"
,"EXP --> THREE_DOT_FOR_ARG"
,"EXP_1 --> EXP_2 OP_1_EXP_2_*"
,"EXP_2 --> EXP_3 OP_2_EXP_3_*"
,"EXP_3 --> EXP_4 OP_3_EXP_4_*"
,"EXP_4 --> EXP_5 OP_4_EXP_5_*"
,"EXP_5 --> EXP_6 OP_5_EXP_6_*"
,"EXP_6 --> EXP_7 OP_6_EXP_7_*"
,"EXP_7 --> EXP_8 OP_7_EXP_8_*"
,"EXP_8 --> EXP_9 OP_8_EXP_9_*"
,"EXP_9 --> EXP_10 OP_9_EXP_10_*"
,"EXP_10 --> EXP_11 OP_10_EXP_11_*"
,"EXP_11 --> _action_beginStatement OP_11 _action_pushId _action_buildOperator EXP_12 _action_endStatement"
,"EXP_11 --> EXP_12"
,"EXP_12 --> _action_beginStatement FUNCTION_CALL OP_12_FUNCTION_CALL_*"
,"FUNCTION_CALL --> VALUE_JUST_AS_FUNCTION"
,"FUNCTION_CALL --> FUNCTION_CALL_WITH_NAME"
,"FUNCTION_CALL --> FUNCTION_CALL_WITHOUT_NAME"
,"VALUE_JUST_AS_FUNCTION --> _action_addFunction FUNCTION_ID_NOT_NAME _action_setFunctionId"
,"FUNCTION_CALL_WITH_NAME --> _action_addFunction FUNCTION_ID _action_setFunctionId FUNCTION_PARAMS_opt"
,"FUNCTION_CALL_WITHOUT_NAME --> _action_addFunction FUNCTION_PARAMS_CANBE_HEADER"
,"FUNCTION_PARAMS_CANBE_HEADER --> _action_markParenthesisParam ( EXPLIST_2_opt ) FUNCTION_PARAMS_2_opt"
,"FUNCTION_PARAMS_CANBE_HEADER --> _action_markStatement { FIELD_LIST_opt } FUNCTION_PARAMS_3_opt"
,"FUNCTION_PARAMS --> FUNCTION_PARAMS_CANBE_HEADER"
,"FUNCTION_PARAMS --> _action_markBracketParam [ EXP ] FUNCTION_PARAMS_4_opt"
,"FUNCTION_PARAMS --> . MEMBER_DESC FUNCTION_PARAMS_5_opt"
,"FUNCTION_PARAMS --> : MEMBER_DESC2 FUNCTION_PARAMS_6_opt"
,"FUNCTION_PARAMS --> _action_markParenthesisColonParam STRING FUNCTION_PARAMS_7_opt"
,"MEMBER_DESC --> _action_markPeriodParam _action_beginStatement _action_addFunction FUNCTION_ID _action_setMemberId _action_endStatement"
,"MEMBER_DESC2 --> _action_markPointerParam _action_beginStatement _action_addFunction FUNCTION_ID _action_setMemberId _action_endStatement"
,"FIELD_LIST --> FIELD FIELD_LIST_TAIL_opt"
,"FIELD_LIST_TAIL --> FIELD_SEP FIELD_LIST_2_opt"
,"FIELD --> _action_beginStatement _action_addFunction _action_markBracketParam [ EXP ] = _action_pushId _action_buildOperator EXP _action_endStatement"
,"FIELD --> FIELD_EXP"
,"FIELD_EXP --> _action_beginStatement _action_addFunction NAME _action_pushId _action_setFunctionId FIELD_NAME_TAIL"
,"FIELD_EXP --> _action_beginStatement _action_addFunction FUNCTION_ID_NOT_NAME _action_pushId _action_setFunctionId FUNCTION_CALL_AFTER_ID _action_endStatement"
,"FIELD_EXP --> FUNCTION_CALL_WITHOUT_NAME_OP _action_endStatement"
,"FIELD_EXP --> _action_beginStatement OP_11 _action_pushId _action_buildOperator EXP_12 _action_endStatement"
,"FIELD_EXP --> FUNCTIONDEF"
,"FIELD_EXP --> THREE_DOT_FOR_ARG"
,"FUNCTION_CALL_WITHOUT_NAME_OP --> _action_beginStatement FUNCTION_CALL_WITHOUT_NAME OP_1_EXP_2_2_*"
,"FIELD_NAME_TAIL --> = _action_pushId _action_buildOperator EXP _action_endStatement"
,"FIELD_NAME_TAIL --> FUNCTION_CALL_AFTER_ID _action_endStatement"
,"FUNCTION_CALL_AFTER_ID --> FUNCTION_PARAMS_8_opt OP_1_EXP_2_3_*"
,"FIELD_SEP --> ,"
,"FIELD_SEP --> ;"
,"FUNCTION_ID --> NAME _action_pushId"
,"FUNCTION_ID_NOT_NAME --> STRING _action_pushStr"
,"FUNCTION_ID_NOT_NAME --> NUMBER _action_pushNum"
,"FUNCTION_ID_NOT_NAME --> TRUE _action_pushId"
,"FUNCTION_ID_NOT_NAME --> FALSE _action_pushId"
,"FUNCTION_ID_NOT_NAME --> NIL _action_pushId"
,"STAT_UNAMBIGUOUS_GROUP_* --> STAT_UNAMBIGUOUS_GROUP STAT_UNAMBIGUOUS_GROUP_*"
,"STAT_UNAMBIGUOUS_GROUP_* -->"
,"RETURN_STAT_opt --> RETURN_STAT"
,"RETURN_STAT_opt -->"
,",_FUNCTION_CALL_* --> , _action_beginStatement FUNCTION_CALL _action_endStatement ,_FUNCTION_CALL_*"
,",_FUNCTION_CALL_* -->"
,"ELSEIF_EXP_THEN_BLOCK_* --> _action_addFunction ELSEIF _action_pushId _action_setFunctionId _action_markParenthesisParam EXP THEN _action_buildHighOrderFunction _action_markStatement BLOCK ELSEIF_EXP_THEN_BLOCK_*"
,"ELSEIF_EXP_THEN_BLOCK_* -->"
,"ELSE_BLOCK_opt --> _action_addFunction ELSE _action_pushId _action_setFunctionId _action_markStatement BLOCK"
,"ELSE_BLOCK_opt -->"
,",_FUNCTION_CALL_2_* --> , _action_beginStatement FUNCTION_CALL _action_endStatement ,_FUNCTION_CALL_2_*"
,",_FUNCTION_CALL_2_* -->"
,"=_EXPLIST_opt --> = _action_addFunction _action_pushAssignWith _action_setFunctionId _action_markParenthesisParam EXPLIST _action_endStatement"
,"=_EXPLIST_opt --> _action_removeLuaList"
,",_EXP_opt --> , EXP"
,",_EXP_opt -->"
,",_NAME_FOR_ARG_* --> , NAME_FOR_ARG ,_NAME_FOR_ARG_*"
,",_NAME_FOR_ARG_* --> _action_addFunction"
,",_NAME_AND_ATTRIB_* --> , NAME_AND_ATTRIB ,_NAME_AND_ATTRIB_*"
,",_NAME_AND_ATTRIB_* -->"
,"<_NAME_FOR_ARG_>_opt --> < _action_beginStatement _action_addFunction _action_markBracketAttrParam NAME_FOR_ARG _action_endStatement > _action_endStatement"
,"<_NAME_FOR_ARG_>_opt --> _action_removeLuaVarAttr"
,"EXPLIST_opt --> EXPLIST"
,"EXPLIST_opt -->"
,";_opt --> ;"
,";_opt -->"
,"DOT_FOR_FUNCNAME_NAME_FOR_ARG_* --> DOT_FOR_FUNCNAME NAME_FOR_ARG DOT_FOR_FUNCNAME_NAME_FOR_ARG_*"
,"DOT_FOR_FUNCNAME_NAME_FOR_ARG_* -->"
,"COLON_FOR_FUNCNAME_NAME_FOR_ARG_opt --> COLON_FOR_FUNCNAME NAME_FOR_ARG"
,"COLON_FOR_FUNCNAME_NAME_FOR_ARG_opt -->"
,"PARLIST_opt --> PARLIST"
,"PARLIST_opt -->"
,"PARLIST_TAIL_opt --> PARLIST_TAIL"
,"PARLIST_TAIL_opt -->"
,",_EXP_* --> , EXP ,_EXP_*"
,",_EXP_* -->"
,"OP_1_EXP_2_* --> OP_1 _action_pushId _action_buildOperator EXP_2 _action_endStatement OP_1_EXP_2_*"
,"OP_1_EXP_2_* -->"
,"OP_2_EXP_3_* --> OP_2 _action_pushId _action_buildOperator EXP_3 _action_endStatement OP_2_EXP_3_*"
,"OP_2_EXP_3_* -->"
,"OP_3_EXP_4_* --> OP_3 _action_pushId _action_buildOperator EXP_4 _action_endStatement OP_3_EXP_4_*"
,"OP_3_EXP_4_* -->"
,"OP_4_EXP_5_* --> OP_4 _action_pushId _action_buildOperator EXP_5 _action_endStatement OP_4_EXP_5_*"
,"OP_4_EXP_5_* -->"
,"OP_5_EXP_6_* --> OP_5 _action_pushId _action_buildOperator EXP_6 _action_endStatement OP_5_EXP_6_*"
,"OP_5_EXP_6_* -->"
,"OP_6_EXP_7_* --> OP_6 _action_pushId _action_buildOperator EXP_7 _action_endStatement OP_6_EXP_7_*"
,"OP_6_EXP_7_* -->"
,"OP_7_EXP_8_* --> OP_7 _action_pushId _action_buildOperator EXP_8 _action_endStatement OP_7_EXP_8_*"
,"OP_7_EXP_8_* -->"
,"OP_8_EXP_9_* --> OP_8 _action_pushId _action_buildOperator EXP_9 _action_endStatement OP_8_EXP_9_*"
,"OP_8_EXP_9_* -->"
,"OP_9_EXP_10_* --> OP_9 _action_pushId _action_buildOperator EXP_10 _action_endStatement OP_9_EXP_10_*"
,"OP_9_EXP_10_* -->"
,"OP_10_EXP_11_* --> OP_10 _action_pushId _action_buildOperator EXP_11 _action_endStatement OP_10_EXP_11_*"
,"OP_10_EXP_11_* -->"
,"OP_12_FUNCTION_CALL_* --> OP_12 _action_pushId _action_buildOperator _action_beginStatement FUNCTION_CALL _action_endStatement OP_12_FUNCTION_CALL_*"
,"OP_12_FUNCTION_CALL_* -->"
,"FUNCTION_PARAMS_opt --> FUNCTION_PARAMS"
,"FUNCTION_PARAMS_opt -->"
,"EXPLIST_2_opt --> EXPLIST"
,"EXPLIST_2_opt -->"
,"FUNCTION_PARAMS_2_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_2_opt -->"
,"FIELD_LIST_opt --> FIELD_LIST"
,"FIELD_LIST_opt -->"
,"FUNCTION_PARAMS_3_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_3_opt -->"
,"FUNCTION_PARAMS_4_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_4_opt -->"
,"FUNCTION_PARAMS_5_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_5_opt -->"
,"FUNCTION_PARAMS_6_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_6_opt -->"
,"FUNCTION_PARAMS_7_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_7_opt -->"
,"FIELD_LIST_TAIL_opt --> FIELD_LIST_TAIL"
,"FIELD_LIST_TAIL_opt -->"
,"FIELD_LIST_2_opt --> FIELD_LIST"
,"FIELD_LIST_2_opt -->"
,"OP_1_EXP_2_2_* --> OP_1 _action_pushId _action_buildOperator EXP_2 _action_endStatement OP_1_EXP_2_2_*"
,"OP_1_EXP_2_2_* -->"
,"FUNCTION_PARAMS_8_opt --> FUNCTION_PARAMS"
,"FUNCTION_PARAMS_8_opt -->"
,"OP_1_EXP_2_3_* --> OP_1 _action_pushId _action_buildOperator EXP_2 _action_endStatement OP_1_EXP_2_3_*"
,"OP_1_EXP_2_3_* -->"
};

private const short   START_SYMBOL = 51;
private const short   START_ACTION = 154;
private const short   END_ACTION = 183;

public static string  GetSymbolName ( short symbol )
{
  if ( symbol >= START_ACTION && symbol < END_ACTION ) {
      return ( Action_name [symbol - (START_ACTION-1)] );
  } else if ( symbol >= START_SYMBOL ) {
      return ( Nonterminal_name [symbol - (START_SYMBOL-1)] );
  } else if ( symbol > 0 ) {
      return ( Terminal_name [ symbol ] );
  }
  return ( "not a symbol" );
}

public static string  GetProductionName ( short production_number )
{
  return ( Production_name [production_number] );
}


};


}
