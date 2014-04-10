#pragma once
#include "generalstack.h"
#include <QTextStream>

// Class for calculator
class Calculator
{
public:
    Calculator(GeneralStack &newStack)
        : stack(newStack)
    {
    }
    ~Calculator();

    // Arithmetic operation
    void operation(QCharRef something);

    // Get value from calculator
    int popValue();

    // Push value to calculator
    void pushResult(int value);

    // Remove calculator
    void removeCalculator(GeneralStack &stack);

private:
    GeneralStack &stack;
};
