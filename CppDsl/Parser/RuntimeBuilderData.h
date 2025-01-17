﻿#ifndef __RuntimeBuilderData_H__
#define __RuntimeBuilderData_H__

#include "Queue.h"
#include "DslParser.h"

#define STACKSIZE			255

namespace DslParser
{
    class FunctionData;
    class StatementData;
    class DslFile;
    class ValueData;
}
class RuntimeBuilderData final
{
public:
    enum
    {
        UNKNOWN_TOKEN = -1,
        ID_TOKEN = 0,
        NUM_TOKEN,
        STRING_TOKEN,
    };
    struct TokenInfo
    {
        char* mString;
        int mType;

        TokenInfo(void) :mString(0), mType(UNKNOWN_TOKEN)
        {}
        TokenInfo(char* pstr, int type) :mString(pstr), mType(type)
        {}
        int IsValid(void)const
        {
            if (UNKNOWN_TOKEN != mType)
                return TRUE;
            else
                return FALSE;
        }
        DslParser::ValueData ToValue(void)const;
    };
private:
    typedef DequeT<TokenInfo, STACKSIZE> TokenStack;
    typedef DequeT<DslParser::StatementData*, STACKSIZE> SemanticStack;
public:
    RuntimeBuilderData(void);
public:
    void push(const TokenInfo& info);
    TokenInfo pop(void);
    int isSemanticStackEmpty(void)const;
    void pushStatement(DslParser::StatementData* p);
    DslParser::StatementData* popStatement(void);
    DslParser::StatementData* getCurStatement(void)const;
    DslParser::FunctionData* getLastFunction(void)const;
    void setLastFunction(DslParser::FunctionData* p)const;
private:
    TokenStack		mTokenStack;
    SemanticStack	mSemanticStack;
public:
    static DslParser::FunctionData*& GetNullFunctionPtrRef()
    {
        static DslParser::FunctionData* s_Ptr = 0;
        return s_Ptr;
    }
};

#endif //__RuntimeBuilderData_H__