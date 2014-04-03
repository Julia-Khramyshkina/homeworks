#pragma once
#include "generalstack.h"
#include <QTextStream>

///
/// \brief The Calculator class
///
class Calculator
{
public:
    Calculator(GeneralStack &newStack)
        : stack(newStack)
    {
    }
    virtual ~Calculator() {}

    ///
    /// \brief operation
    /// \param something
    ///
    void operation(QCharRef something);

    ///
    /// \brief popValue
    /// \return
    ///
    int popValue();

    ///
    /// \brief pushResult
    /// \param value
    ///
    ///
    void pushResult(int value);

    ///
    /// \brief removeCalculator
    ///
    void removeCalculator(GeneralStack &stack);

private:
    GeneralStack &stack;
};

