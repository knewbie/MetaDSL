﻿/*****************************************************************************

calc.h

******************************************************************************/

#ifndef _CALC_H
#define _CALC_H

#include "BaseType.h"

namespace Dsl
{
    template<typename DestT>
    struct ReinterpretCast
    {
        template<typename SrcT>
        static DestT From(const SrcT& v)
        {
            union
            {
                SrcT m_Src;
                DestT m_Dest;
            } tmp;
            tmp.m_Src = v;
            return tmp.m_Dest;
        }
    };

    enum
    {
        MAX_ERROR_INFO_CAPACITY = 256,
        MAX_RECORD_ERROR_NUM = 16,

        INIT_FUNCTION_PARAM = 1,
        DELTA_FUNCTION_PARAM = 2,
        DELTA_FUNCTION_STATEMENT = 16,
        INIT_STATEMENT_FUNCTION = 1,
        DELTA_STATEMENT_FUNCTION = 1,
        DELTA_COMMENT = 2,
    };

    enum
    {
        MAX_FUNCTION_DIMENSION_NUM = 8,
        MAX_FUNCTION_PARAM_NUM = 1024,
        MAX_PROGRAM_SIZE = 16 * 1024,
        STRING_BUFFER_SIZE = 1024 * 1024,
        SYNTAXCOMPONENT_POOL_SIZE = 16 * 1024,
    };

    class DslOptions
    {
    public:
        DslOptions(void) :
            m_MaxFunctionDimensionNum(MAX_FUNCTION_DIMENSION_NUM),
            m_MaxParamNum(MAX_FUNCTION_PARAM_NUM),
            m_MaxProgramSize(MAX_PROGRAM_SIZE)
        {
        }
    public:
        int GetMaxFunctionDimensionNum() const { return m_MaxFunctionDimensionNum; }
        void SetMaxFunctionDimensionNum(int val) { m_MaxFunctionDimensionNum = val; }
        int GetMaxParamNum() const { return m_MaxParamNum; }
        void SetMaxParamNum(int val) { m_MaxParamNum = val; }
        int GetMaxProgramSize() const { return m_MaxProgramSize; }
        void SetMaxProgramSize(int val) { m_MaxProgramSize = val; }
    private:
        int	m_MaxFunctionDimensionNum;
        int	m_MaxParamNum;
        int	m_MaxProgramSize;
    };

    class ISyntaxComponent
    {
    public:
        enum
        {
            TYPE_NULL,
            TYPE_VALUE,
            TYPE_FUNCTION,
            TYPE_STATEMENT,
        };
    public:
        ISyntaxComponent(int syntaxType);
        virtual ~ISyntaxComponent(void);
    public:
        virtual int IsValid(void) const = 0;
        virtual const char* GetId(void) const = 0;
        virtual int GetIdType(void) const = 0;
        virtual int GetLine(void) const = 0;
        virtual void WriteToFile(FILE* fp, int indent, int firstLineNoIndent, int isLastOfStatement) const = 0;
    public:
        int GetSyntaxType(void) const { return m_SyntaxType; }
        void AddFirstComment(const char* cmt)
        {
            PrepareFirstComments();
            if (m_FirstCommentNum < m_FirstCommentSpace) {
                m_FirstComments[m_FirstCommentNum++] = cmt;
            }
        }
        void RemoveFirstComment(int index)
        {
            if (index >= 0 && index < m_FirstCommentNum) {
                for (int ix = index; ix < m_FirstCommentNum - 1; ++ix) {
                    m_FirstComments[ix] = m_FirstComments[ix + 1];
                }
                --m_FirstCommentNum;
            }
        }
        void ClearFirstComments()
        {
            m_FirstCommentNum = 0;
        }
        int GetFirstCommentNum(void) const { return m_FirstCommentNum; }
        const char* GetFirstComment(int index) const
        {
            if (index >= 0 && index < m_FirstCommentNum) {
                return m_FirstComments[index];
            }
            else {
                return 0;
            }
        }
        int IsFirstCommentOnNewLine(void) const { return m_FirstCommentOnNewLine; }
        void SetFirstCommentOnNewLine(int v) { m_FirstCommentOnNewLine = v; }
        void AddLastComment(const char* cmt)
        {
            PrepareLastComments();
            if (m_LastCommentNum < m_LastCommentSpace) {
                m_LastComments[m_LastCommentNum++] = cmt;
            }
        }
        void RemoveLastComment(int index)
        {
            if (index >= 0 && index < m_LastCommentNum) {
                for (int ix = index; ix < m_LastCommentNum - 1; ++ix) {
                    m_LastComments[ix] = m_LastComments[ix + 1];
                }
                --m_LastCommentNum;
            }
        }
        void ClearLastComments()
        {
            m_LastCommentNum = 0;
        }
        int GetLastCommentNum(void) const { return m_LastCommentNum; }
        const char* GetLastComment(int index) const
        {
            if (index >= 0 && index < m_LastCommentNum) {
                return m_LastComments[index];
            }
            else {
                return 0;
            }
        }
        int IsLastCommentOnNewLine(void) const { return m_LastCommentOnNewLine; }
        void SetLastCommentOnNewLine(int v) { m_LastCommentOnNewLine = v; }
        void CopyComments(const ISyntaxComponent& other)
        {
            CopyFirstComments(other);
            CopyLastComments(other);
        }
        void CopyFirstComments(const ISyntaxComponent& other)
        {
            int fnum = other.GetFirstCommentNum();
            if (fnum > 0) {
                m_FirstCommentOnNewLine = other.m_FirstCommentOnNewLine;
                for (int i = 0; i < fnum; ++i) {
                    AddFirstComment(other.GetFirstComment(i));
                }
            }
        }
        void CopyLastComments(const ISyntaxComponent& other)
        {
            int lnum = other.GetLastCommentNum();
            if (lnum > 0) {
                m_LastCommentOnNewLine = other.m_LastCommentOnNewLine;
                for (int i = 0; i < lnum; ++i) {
                    AddLastComment(other.GetLastComment(i));
                }
            }
        }
    public:
        void WriteFirstCommentsToFile(FILE* fp, int indent, int firstLineNoIndent) const;
        void WriteLastCommentsToFile(FILE* fp, int indent, int isLastOfStatement) const;
    protected:
        void CopyFrom(const ISyntaxComponent& other);
    private:
        void PrepareFirstComments(void);
        void ReleaseFirstComments(void);
        void PrepareLastComments(void);
        void ReleaseLastComments(void);
    private:
        int m_SyntaxType;
        const char** m_FirstComments;
        int m_FirstCommentNum;
        int m_FirstCommentSpace;
        int m_FirstCommentOnNewLine;
        const char** m_LastComments;
        int m_LastCommentNum;
        int m_LastCommentSpace;
        int m_LastCommentOnNewLine;
    };

    class FunctionData;
    class ValueData : public ISyntaxComponent
    {
    public:
        enum
        {
            TYPE_IDENTIFIER = 0,
            TYPE_NUM,
            TYPE_STRING,
            TYPE_BOOL,
            TYPE_FUNCTION,
            TYPE_MAX = TYPE_BOOL
        };

        ValueData(void) :ISyntaxComponent(ISyntaxComponent::TYPE_VALUE), m_Type(TYPE_IDENTIFIER), m_StringVal(0), m_Line(0) {}
        explicit ValueData(char* val) :ISyntaxComponent(ISyntaxComponent::TYPE_VALUE), m_Type(TYPE_STRING), m_StringVal(val), m_Line(0) {}
        explicit ValueData(const char* val) :ISyntaxComponent(ISyntaxComponent::TYPE_VALUE), m_Type(TYPE_STRING), m_ConstStringVal(val), m_Line(0) {}
        explicit ValueData(FunctionData* val) :ISyntaxComponent(ISyntaxComponent::TYPE_VALUE), m_Type(TYPE_FUNCTION), m_FunctionVal(val), m_Line(0) {}
        explicit ValueData(char* val, int type) :ISyntaxComponent(ISyntaxComponent::TYPE_VALUE), m_Type(type), m_StringVal(val), m_Line(0) {}
        explicit ValueData(const char* val, int type) :ISyntaxComponent(ISyntaxComponent::TYPE_VALUE), m_Type(type), m_ConstStringVal(val), m_Line(0) {}
        ValueData(const ValueData& other) :ISyntaxComponent(ISyntaxComponent::TYPE_VALUE), m_Type(TYPE_IDENTIFIER), m_StringVal(0), m_Line(0)
        {
            ISyntaxComponent::CopyFrom(other);
            CopyFrom(other);
        }
        ValueData& operator=(const ValueData& other)
        {
            if (this == &other)
                return *this;
            ISyntaxComponent::CopyFrom(other);
            CopyFrom(other);
            return *this;
        }

        virtual int IsValid(void)const;
        virtual int GetIdType(void)const;
        virtual const char* GetId(void)const;
        virtual int GetLine(void)const;
        virtual void WriteToFile(FILE* fp, int indent, int firstLineNoIndent, int isLastOfStatement) const;

        FunctionData* GetFunction(void)const { return m_FunctionVal; }

        int HaveId()const;
        int IsNum(void)const { return (m_Type == TYPE_NUM ? TRUE : FALSE); }
        int IsString(void)const { return (m_Type == TYPE_STRING ? TRUE : FALSE); }
        int IsIdentifier(void)const { return (m_Type == TYPE_IDENTIFIER ? TRUE : FALSE); }
        int IsFunction(void)const { return (m_Type == TYPE_FUNCTION ? TRUE : FALSE); }

        void SetInvalid(void)
        {
            m_Type = TYPE_IDENTIFIER;
            m_StringVal = 0;
        }
        void SetNumber(char* str)
        {
            m_Type = TYPE_NUM;
            m_StringVal = str;
        }
        void SetNumber(const char* str)
        {
            m_Type = TYPE_NUM;
            m_ConstStringVal = str;
        }
        void SetString(char* str)
        {
            m_Type = TYPE_STRING;
            m_StringVal = str;
        }
        void SetString(const char* str)
        {
            m_Type = TYPE_STRING;
            m_ConstStringVal = str;
        }
        void SetBool(char* str)
        {
            m_Type = TYPE_BOOL;
            m_StringVal = str;
        }
        void SetBool(const char* str)
        {
            m_Type = TYPE_BOOL;
            m_ConstStringVal = str;
        }
        void SetFunction(FunctionData* func)
        {
            m_Type = TYPE_FUNCTION;
            m_FunctionVal = func;
        }
        void SetIdentifier(char* name)
        {
            m_Type = TYPE_IDENTIFIER;
            m_StringVal = name;
        }
        void SetLine(int line)
        {
            m_Line = line;
        }
        void SetTypeAndId(int type, const char* id)
        {
            m_Type = type;
            m_ConstStringVal = id;
        }
    private:
        void CopyFrom(const ValueData& other)
        {
            m_Type = other.m_Type;
            m_StringVal = other.m_StringVal;
            m_Line = other.m_Line;
        }
    private:
        int m_Type;
        union
        {
            char* m_StringVal;
            const char* m_ConstStringVal;//在脚本里与m_StringVal类型相同,用于实现自动const_cast
            FunctionData* m_FunctionVal;
        };
        int m_Line;
    };

    class NullSyntax : public ISyntaxComponent
    {
    public:
        NullSyntax(void) : ISyntaxComponent(ISyntaxComponent::TYPE_NULL) {}
    public:
        virtual int IsValid(void) const { return FALSE; }
        virtual const char* GetId(void) const { return ""; }
        virtual int GetIdType(void) const { return ValueData::TYPE_IDENTIFIER; }
        virtual int GetLine(void) const { return 0; }
        virtual void WriteToFile(FILE* fp, int indent, int firstLineNoIndent, int isLastOfStatement) const {}
    private:
        NullSyntax(const NullSyntax&) = delete;
        NullSyntax& operator=(const NullSyntax&) = delete;
    };

    class IDslStringAndObjectBuffer;
    class FunctionData : public ISyntaxComponent
    {
    public:
        enum
        {
            PARAM_CLASS_NOTHING = 0,
            PARAM_CLASS_PARENTHESIS,
            PARAM_CLASS_BRACKET,
            PARAM_CLASS_PERIOD,
            PARAM_CLASS_PERIOD_PARENTHESIS,
            PARAM_CLASS_PERIOD_BRACKET,
            PARAM_CLASS_PERIOD_BRACE,
            PARAM_CLASS_QUESTION_PERIOD,
            PARAM_CLASS_QUESTION_PARENTHESIS,
            PARAM_CLASS_QUESTION_BRACKET,
            PARAM_CLASS_QUESTION_BRACE,
            PARAM_CLASS_POINTER,
            PARAM_CLASS_STATEMENT,
            PARAM_CLASS_EXTERN_SCRIPT,
            PARAM_CLASS_PERIOD_STAR,
            PARAM_CLASS_QUESTION_PERIOD_STAR,
            PARAM_CLASS_POINTER_STAR,
            PARAM_CLASS_OPERATOR,
            PARAM_CLASS_TERNARY_OPERATOR,
            PARAM_CLASS_MAX,
            PARAM_CLASS_WRAP_INFIX_CALL_MASK = 0x20,
            PARAM_CLASS_UNMASK = 0x1F,
        };
        typedef ISyntaxComponent* SyntaxComponentPtr;
    public:
        virtual int IsValid(void)const
        {
            if (m_Name.IsValid())
                return TRUE;
            else if (HaveParamOrStatement())
                return TRUE;
            else
                return FALSE;
        }
        virtual int GetIdType(void)const { return m_Name.GetIdType(); }
        virtual const char* GetId(void)const { return m_Name.GetId(); }
        virtual int GetLine(void)const { return m_Name.GetLine(); }
        virtual void WriteToFile(FILE* fp, int indent, int firstLineNoIndent, int isLastOfStatement) const;
    public:
        void SetName(const ValueData& val) { m_Name = val; }
        ValueData& GetName(void) { return m_Name; }
        void ClearParams(void) { m_ParamNum = 0; }
        void AddParam(ISyntaxComponent*	pVal)
        {
            if (0 == pVal || m_ParamNum < 0 || m_ParamNum >= m_MaxParamNum)
                return;
            PrepareParams();
            if (0 == m_Params || m_ParamNum >= m_ParamSpace)
                return;
            m_Params[m_ParamNum] = pVal;
            ++m_ParamNum;
        }
        void SetParam(int index, ISyntaxComponent* pVal)
        {
            if (NULL == pVal || index < 0 || index >= m_MaxParamNum)
                return;
            m_Params[index] = pVal;
        }
        void SetParamClass(int v) { m_ParamClass = v; }
        int GetParamClass(void)const { return m_ParamClass; }
        int HaveId(void)const { return m_Name.HaveId(); }
        int HaveParamOrStatement(void)const { return m_ParamClass != PARAM_CLASS_NOTHING ? TRUE : FALSE; }
        int HaveParam(void)const { return HaveParamOrStatement() && !HaveStatement() && !HaveExternScript(); }
        int HaveStatement(void)const { return m_ParamClass == PARAM_CLASS_STATEMENT ? TRUE : FALSE; }
        int HaveExternScript(void)const { return m_ParamClass == PARAM_CLASS_EXTERN_SCRIPT ? TRUE : FALSE; }
        int IsHighOrder(void)const { return m_Name.IsFunction(); }
        FunctionData* GetLowerOrderFunction(void)const
        {
            auto fptr = m_Name.GetFunction();
            if (IsHighOrder() && fptr) {
                return fptr;
            }
            else {
                return GetNullFunctionPtr();
            }
        }
        const FunctionData* GetThisOrLowerOrderCall(void)const
        {
            if (HaveParam()) {
                return this;
            }
            else if (HaveLowerOrderParam()) {
                return m_Name.GetFunction();
            }
            else {
                return GetNullFunctionPtr();
            }
        }
        FunctionData* GetThisOrLowerOrderCall(void)
        {
            if (HaveParam()) {
                return this;
            }
            else if (HaveLowerOrderParam()) {
                return m_Name.GetFunction();
            }
            else {
                return GetNullFunctionPtr();
            }
        }
        const FunctionData* GetThisOrLowerOrderBody(void)const
        {
            if (HaveStatement()) {
                return this;
            }
            else if (HaveLowerOrderStatement()) {
                return m_Name.GetFunction();
            }
            else {
                return GetNullFunctionPtr();
            }
        }
        FunctionData* GetThisOrLowerOrderBody(void)
        {
            if (HaveStatement()) {
                return this;
            }
            else if (HaveLowerOrderStatement()) {
                return m_Name.GetFunction();
            }
            else {
                return GetNullFunctionPtr();
            }
        }
        const FunctionData* GetThisOrLowerOrderScript(void)const
        {
            if (HaveExternScript()) {
                return this;
            }
            else if (HaveLowerOrderExternScript()) {
                return m_Name.GetFunction();
            }
            else {
                return GetNullFunctionPtr();
            }
        }
        FunctionData* GetThisOrLowerOrderScript(void)
        {
            if (HaveExternScript()) {
                return this;
            }
            else if (HaveLowerOrderExternScript()) {
                return m_Name.GetFunction();
            }
            else {
                return GetNullFunctionPtr();
            }
        }
        int HaveLowerOrderParam(void)const
        {
            auto fptr = m_Name.GetFunction();
            if (IsHighOrder() && fptr && fptr->HaveParam())
                return TRUE;
            else
                return FALSE;
        }
        int HaveLowerOrderStatement(void)const
        {
            auto fptr = m_Name.GetFunction();
            if (IsHighOrder() && fptr && fptr->HaveStatement())
                return TRUE;
            else
                return FALSE;
        }
        int HaveLowerOrderExternScript(void)const
        {
            auto fptr = m_Name.GetFunction();
            if (IsHighOrder() && fptr && fptr->HaveExternScript())
                return TRUE;
            else
                return FALSE;
        }
    public:
        const ValueData& GetName(void)const { return m_Name; }
        int GetParamNum(void)const { return m_ParamNum; }
        ISyntaxComponent* GetParam(int index)const
        {
            if (0 == m_Params || index < 0 || index >= m_ParamNum || index >= m_MaxParamNum)
                return GetNullSyntaxPtr();
            return m_Params[index];
        }
        const char* GetParamId(int index)const
        {
            if (0 == m_Params || index < 0 || index >= m_ParamNum || index >= m_MaxParamNum)
                return "";
            return m_Params[index]->GetId();
        }
    public:
        void AddComment(const char* cmt)
        {
            PrepareComments();
            if (m_CommentNum < m_CommentSpace) {
                m_Comments[m_CommentNum++] = cmt;
            }
        }
        void RemoveComment(int index)
        {
            if (index >= 0 && index < m_CommentNum) {
                for (int ix = index; ix < m_CommentNum - 1; ++ix) {
                    m_Comments[ix] = m_Comments[ix + 1];
                }
                --m_CommentNum;
            }
        }
        void ClearComments()
        {
            m_CommentNum = 0;
        }
        int GetCommentNum(void) const { return m_CommentNum; }
        const char* GetComment(int index) const
        {
            if (index >= 0 && index < m_CommentNum) {
                return m_Comments[index];
            }
            else {
                return 0;
            }
        }
    public:
        FunctionData(IDslStringAndObjectBuffer& buffer);
        virtual ~FunctionData(void);
    private:
        FunctionData(const FunctionData& other) = delete;
        FunctionData operator=(const FunctionData& other) = delete;
    private:
        void PrepareParams(void);
        void ReleaseParams(void);
        void PrepareComments(void);
        void ReleaseComments(void);
    private:
        NullSyntax* GetNullSyntaxPtr(void)const;
        FunctionData* GetNullFunctionPtr(void)const;
    private:
        ValueData m_Name;
        ISyntaxComponent**	m_Params;
        int m_ParamNum;
        int m_ParamSpace;
        int m_MaxParamNum;
        int m_ParamClass;
        const char** m_Comments;
        int m_CommentNum;
        int m_CommentSpace;
    private:
        IDslStringAndObjectBuffer& m_Buffer;
    };
    
    /* 备忘：为什么StatementData的成员不使用ISyntaxComponent[]而是FunctionData[]
     * 1、虽然语法上这里的FunctionData可以退化为ValueData，但不可以是StatementData，这样在概念上不能与ISyntaxComponent等同
     * 2、在设计上，FunctionData应该考虑到退化情形，尽量在退化情形不占用额外空间
     */
    class StatementData : public ISyntaxComponent
    {
    public:
        virtual int IsValid(void)const
        {
            if (NULL != m_Functions && m_FunctionNum > 0 && m_Functions[0]->IsValid())
                return TRUE;
            else
                return FALSE;
        }
        virtual int GetIdType(void)const
        {
            int type = ValueData::TYPE_IDENTIFIER;
            if (IsValid()) {
                type = m_Functions[0]->GetIdType();
            }
            return type;
        }
        virtual const char* GetId(void)const
        {
            const char* str = "";
            if (IsValid()) {
                str = m_Functions[0]->GetId();
            }
            return str;
        }
        virtual int GetLine(void)const
        {
            int line = 0;
            if (IsValid()) {
                line = m_Functions[0]->GetLine();
            }
            return line;
        }
        virtual void WriteToFile(FILE* fp, int indent, int firstLineNoIndent, int isLastOfStatement) const;
    public:
        void ClearFunctions(void) { m_FunctionNum = 0; }
        void AddFunction(FunctionData* pVal)
        {
            if (NULL == pVal || m_FunctionNum < 0 || m_FunctionNum >= m_MaxFunctionNum)
                return;
            PrepareFunctions();
            if (NULL == m_Functions || m_FunctionNum >= m_FunctionSpace)
                return;
            m_Functions[m_FunctionNum] = pVal;
            ++m_FunctionNum;
        }
        FunctionData*& GetLastFunctionRef(void)const
        {
            if (NULL == m_Functions || 0 == m_FunctionNum)
                return GetNullFunctionPtrRef();
            else
                return m_Functions[m_FunctionNum - 1];
        }
    public:
        int GetFunctionNum(void)const { return m_FunctionNum; }
        FunctionData* GetFunction(int index)const
        {
            if (NULL == m_Functions || index < 0 || index >= m_FunctionNum || index >= m_MaxFunctionNum)
                return 0;
            return m_Functions[index];
        }
        const char* GetFunctionId(int index)const
        {
            if (0 == m_Functions || index < 0 || index >= m_FunctionNum || index >= m_MaxFunctionNum)
                return 0;
            return m_Functions[index]->GetId();
        }
    public:
        StatementData(IDslStringAndObjectBuffer& buffer);
        virtual ~StatementData(void)
        {
            ReleaseFunctions();
        }
    private:
        StatementData(const StatementData&) = delete;
        StatementData& operator=(const StatementData&) = delete;
    private:
        void PrepareFunctions(void);
        void ReleaseFunctions(void);
    private:
        FunctionData*& GetNullFunctionPtrRef(void)const;
    private:
        FunctionData** m_Functions;
        int m_FunctionNum;
        int m_FunctionSpace;
        int m_MaxFunctionNum;
    private:
        IDslStringAndObjectBuffer& m_Buffer;
    };

    //在c++实现里，DSL的内存希望尽量是预先分配的，这个接口用来实现预先分配的内存
    class IDslStringAndObjectBuffer
    {
    public:
        virtual DslOptions& GetOptions(void) = 0;
        virtual const DslOptions& GetOptions(void)const = 0;
    public:
        virtual char* AllocString(int len) = 0;
        virtual char* AllocString(const char* src) = 0;
        virtual char* GetStringBuffer(void)const = 0;
        virtual char*& GetUnusedStringPtrRef(void) = 0;
        virtual int GetUnusedStringLength(void)const = 0;
    public:
        virtual ValueData* AddNewValueComponent(void) = 0;
        virtual FunctionData* AddNewFunctionComponent(void) = 0;
        virtual StatementData* AddNewStatementComponent(void) = 0;
    public:
        virtual NullSyntax* GetNullSyntaxPtr(void) = 0;
        virtual FunctionData* GetNullFunctionPtr(void) = 0;
        virtual FunctionData*& GetNullFunctionPtrRef(void) = 0;
    public:
        virtual ~IDslStringAndObjectBuffer(void) {}
    };

    /*
     * 实际的DSL预先分配缓冲区，这个类需要在堆上实例化（在栈上可能导致栈溢出），类本身使
     * 用数组来分配缓冲区。
     * 目前只有字符串与语句池是预先分配的，理想情况是所有相关类使用的内存都是预先分配的，
     * 目前各语法组件对象（ValueData、FunctionData、StatementData）及对象内所包含的指
     * 针列表(参数列表与语句列表)还没有实现预先分配。
     */
    template<int MaxStringBufferLength = STRING_BUFFER_SIZE, int SyntaxComponentPoolSize = SYNTAXCOMPONENT_POOL_SIZE>
    class DslStringAndObjectBuffer : public IDslStringAndObjectBuffer
    {
        typedef ISyntaxComponent* SyntaxComponentPtr;
    public:
        DslOptions& GetOptions(void) { return m_Options; }
        const DslOptions& GetOptions(void)const { return m_Options; }
    public:
        char* AllocString(int len);
        char* AllocString(const char* src);
        char* GetStringBuffer(void)const { return m_pStringBuffer; }
        char*& GetUnusedStringPtrRef(void) { return m_pUnusedStringPtr; }
        int GetUnusedStringLength(void)const
        {
            MyAssert(m_pStringBuffer);
            MyAssert(m_ppUnusedStringRef);
            return MaxStringBufferLength - int(m_pUnusedStringPtr - m_pStringBuffer);
        }
    public:
        ValueData* AddNewValueComponent(void);
        FunctionData* AddNewFunctionComponent(void);
        StatementData* AddNewStatementComponent(void);
    public:
        NullSyntax* GetNullSyntaxPtr(void)
        {
            return &m_NullSyntax;
        }
        FunctionData* GetNullFunctionPtr(void)
        {
            m_NullFunction.GetName().SetInvalid();
            m_NullFunction.SetParamClass(FunctionData::PARAM_CLASS_NOTHING);
            m_NullFunction.ClearParams();
            return &m_NullFunction;
        }
        FunctionData*& GetNullFunctionPtrRef(void)
        {
            auto fptr = m_pNullFunction;
            fptr->GetName().SetInvalid();
            fptr->SetParamClass(FunctionData::PARAM_CLASS_NOTHING);
            fptr->ClearParams();
            return m_pNullFunction;
        }
    public:
        DslStringAndObjectBuffer(void) :m_SyntaxComponentNum(0), m_NullSyntax(), m_NullFunction(*this)
        {
            m_pStringBuffer = m_StringBuffer;
            m_pUnusedStringPtr = m_pStringBuffer;

            m_pNullFunction = &m_NullFunction;
        }
    private:
        void AddSyntaxComponent(ISyntaxComponent* p);
    private:
        DslStringAndObjectBuffer(const DslStringAndObjectBuffer&) = delete;
        DslStringAndObjectBuffer& operator=(const DslStringAndObjectBuffer&) = delete;
    private:
        DslOptions m_Options;
    private:
        char m_StringBuffer[MaxStringBufferLength];
        char* m_pStringBuffer;
        char* m_pUnusedStringPtr;
    private:
        SyntaxComponentPtr m_SyntaxComponentPool[SyntaxComponentPoolSize];
        int m_SyntaxComponentNum;
    private:
        NullSyntax m_NullSyntax;
        FunctionData m_NullFunction;
        FunctionData* m_pNullFunction;
    };
    
    class IScriptSource;
    class DslFile
    {
        typedef ISyntaxComponent* SyntaxComponentPtr;
    public:
        int GetDslInfoNum(void)const { return m_DslInfoNum; }
        ISyntaxComponent* GetDslInfo(int index)const
        {
            if (index < 0 || index >= m_DslInfoNum)
                return NULL;
            return m_DslInfos[index];
        }
        void WriteToFile(FILE* fp, int indent) const;
    public:
        void AddDslInfo(ISyntaxComponent* p);
    public:
        DslFile(IDslStringAndObjectBuffer& buffer);
        ~DslFile(void);
        void Reset(void);
        void Parse(const char* buf);
        void Parse(IScriptSource& source);
    public:
        void LoadBinaryFile(const char* file);
        void LoadBinaryCode(const char* buffer, int bufferSize);
        void SaveBinaryFile(const char* file) const;
    private:
        DslFile(const DslFile&) = delete;
        DslFile& operator=(const DslFile&) = delete;
    private:
        void Init(void);
        void Release(void);
    public:
        void EnableDebugInfo(void) { m_IsDebugInfoEnable = TRUE; }
        void DisableDebugInfo(void) { m_IsDebugInfoEnable = FALSE; }
        int IsDebugInfoEnable(void)const { return m_IsDebugInfoEnable; }
    public:
        void ClearErrorInfo(void);
        void AddError(const char* error);
        int HasError(void)const { return m_HasError; }
        int GetErrorNum(void)const { return m_ErrorNum; }
        const char*	GetErrorInfo(int index) const
        {
            if (index < 0 || index >= m_ErrorNum || index >= MAX_RECORD_ERROR_NUM)
                return "";
            return m_ErrorInfo[index];
        }
        char* NewErrorInfo(void)
        {
            m_HasError = TRUE;
            if (m_ErrorNum < MAX_RECORD_ERROR_NUM) {
                ++m_ErrorNum;
                return m_ErrorInfo[m_ErrorNum - 1];
            }
            else {
                return 0;
            }
        }
    public:
        char* AllocString(int len) const { return m_Buffer.AllocString(len); }
        char* AllocString(const char* src) const { return m_Buffer.AllocString(src); }
        char* GetStringBuffer(void) const { return m_Buffer.GetStringBuffer(); }
        char*& GetUnusedStringPtrRef(void) const { return m_Buffer.GetUnusedStringPtrRef(); }
        int GetUnusedStringLength(void) const { return m_Buffer.GetUnusedStringLength(); }
    public:
        ValueData* AddNewValueComponent(void) const { return m_Buffer.AddNewValueComponent(); }
        FunctionData* AddNewFunctionComponent(void) const { return m_Buffer.AddNewFunctionComponent(); }
        StatementData* AddNewStatementComponent(void) const { return m_Buffer.AddNewStatementComponent(); }
    public:
        NullSyntax* GetNullSyntaxPtr(void) const { return m_Buffer.GetNullSyntaxPtr(); }
        FunctionData* GetNullFunctionPtr(void) { return m_Buffer.GetNullFunctionPtr(); }
        FunctionData*& GetNullFunctionPtrRef(void) { return m_Buffer.GetNullFunctionPtrRef(); }
    private:
        IDslStringAndObjectBuffer& m_Buffer;
    private:
        SyntaxComponentPtr* m_DslInfos;
        int m_DslInfoNum;
    private:
        int m_IsDebugInfoEnable;
    private:
        int	m_HasError;
        char m_ErrorInfo[MAX_RECORD_ERROR_NUM][MAX_ERROR_INFO_CAPACITY];
        int m_ErrorNum;
    };

    class IScriptSource
    {
    public:
        virtual ~IScriptSource(void) {}
    public:
        class Iterator
        {
        public:
            const char& operator * (void) const
            {
                return Peek(0);
            }
            Iterator& operator ++ (void)
            {
                Advance();
                return *this;
            }
            const Iterator operator ++ (int)
            {
                Iterator it = *this;
                ++(*this);
                return it;
            }
            const Iterator operator + (int val) const
            {
                Iterator it = *this;
                for (int ix = 0; ix < val; ++ix)
                    it.Advance();
                return it;
            }
            int Load(void)
            {
                if (NULL != m_pSource) {
                    int r = m_pSource->Load();
                    if (r) {
                        *this = m_pSource->GetIterator();
                    }
                    return r;
                }
                else {
                    return FALSE;
                }
            }
            const char* GetBuffer(void)const
            {
                return m_pSource->GetBuffer();
            }
            const char* GetLeft(void)const
            {
                return m_Iterator;
            }
        public:
            int operator ==(const Iterator& other) const
            {
                return m_pSource == other.m_pSource && m_Iterator == other.m_Iterator && m_EndIterator == other.m_EndIterator;
            }
            int operator !=(const Iterator& other) const
            {
                return !(operator ==(other));
            }
        public:
            Iterator(void) :m_pSource(NULL), m_Iterator(""), m_EndIterator(m_Iterator)
            {
            }
            explicit Iterator(IScriptSource& source) :m_pSource(&source)
            {
                const char* p = m_pSource->GetBuffer();
                if (0 == p) {
                    m_Iterator = "";
                    m_EndIterator = m_Iterator;
                }
                else {
                    m_Iterator = p;
                    m_EndIterator = m_Iterator + strlen(p);
                }
            }
            Iterator(const Iterator& other)
            {
                CopyFrom(other);
            }
            Iterator& operator=(const Iterator& other)
            {
                if (this == &other)
                    return *this;
                CopyFrom(other);
                return *this;
            }
        private:
            const char& Peek(int index)const
            {
                if (m_Iterator + index < m_EndIterator)
                    return *(m_Iterator + index);
                else
                    return *m_EndIterator;
            }
            void Advance(void)
            {
                if (m_Iterator < m_EndIterator)
                    ++m_Iterator;
            }
            void CopyFrom(const Iterator& other)
            {
                m_pSource = other.m_pSource;
                m_Iterator = other.m_Iterator;
                m_EndIterator = other.m_EndIterator;
            }
        private:
            IScriptSource* m_pSource;
            const char* m_Iterator;
            const char* m_EndIterator;
        };
        friend class Iterator;
    public:
        Iterator GetIterator(void)
        {
            return Iterator(*this);
        }
    protected:
        virtual int Load(void) = 0;
        virtual const char* GetBuffer(void)const = 0;
    };

    template<int MaxStringBufferLength, int SyntaxComponentPoolSize>
    inline ValueData* DslStringAndObjectBuffer<MaxStringBufferLength, SyntaxComponentPoolSize>::AddNewValueComponent(void)
    {
        ValueData* p = new ValueData();
        AddSyntaxComponent(p);
        return p;
    }

    template<int MaxStringBufferLength, int SyntaxComponentPoolSize>
    inline FunctionData* DslStringAndObjectBuffer<MaxStringBufferLength, SyntaxComponentPoolSize>::AddNewFunctionComponent(void)
    {
        FunctionData* p = new FunctionData(*this);
        AddSyntaxComponent(p);
        return p;
    }

    template<int MaxStringBufferLength, int SyntaxComponentPoolSize>
    inline StatementData* DslStringAndObjectBuffer<MaxStringBufferLength, SyntaxComponentPoolSize>::AddNewStatementComponent(void)
    {
        StatementData* p = new StatementData(*this);
        AddSyntaxComponent(p);
        return p;
    }

    template<int MaxStringBufferLength, int SyntaxComponentPoolSize>
    inline void DslStringAndObjectBuffer<MaxStringBufferLength, SyntaxComponentPoolSize>::AddSyntaxComponent(ISyntaxComponent* p)
    {
        if (m_SyntaxComponentNum >= SyntaxComponentPoolSize || 0 == m_SyntaxComponentPool)
            return;
        m_SyntaxComponentPool[m_SyntaxComponentNum] = p;
        ++m_SyntaxComponentNum;
    }

    template<int MaxStringBufferLength, int SyntaxComponentPoolSize>
    inline char* DslStringAndObjectBuffer<MaxStringBufferLength, SyntaxComponentPoolSize>::AllocString(int len)
    {
        if (m_pUnusedStringPtr + len - m_pStringBuffer >= MaxStringBufferLength) {
            return 0;
        }
        char* p = m_pUnusedStringPtr;
        if (0 != p) {
            m_pUnusedStringPtr[len] = 0;
            m_pUnusedStringPtr += len + 1;
        }
        return p;
    }

    template<int MaxStringBufferLength, int SyntaxComponentPoolSize>
    inline char* DslStringAndObjectBuffer<MaxStringBufferLength, SyntaxComponentPoolSize>::AllocString(const char* src)
    {
        if (0 == src)
            return 0;
        int len = (int)strlen(src);
        char* p = AllocString(len);
        if (0 != p) {
            strcpy(p, src);
        }
        return p;
    }
}
using namespace Dsl;

#endif
