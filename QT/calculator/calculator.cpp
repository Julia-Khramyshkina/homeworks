#include "calculator.h"

Calculator::~Calculator()
{}

void Calculator::operation(QCharRef something)
{
    if (something == '+')
    {
        this->pushResult(this->popValue() + this->popValue());
    }

    if (something == '-')
    {
        this->pushResult(this->popValue() - this->popValue());
    }

    if (something == '*')
    {
        this->pushResult(this->popValue() * this->popValue());
    }

    if (something == '/')
    {
        int const number1 = this->popValue();
        int const number2 = this->popValue();
        if (number1 == 0)
            throw QString("Division by 0");
        this->pushResult(number2 / number1);
    }
}

int Calculator::popValue()
{
    return this->stack.pop();
}

void Calculator::pushResult(int value)
{
    this->stack.push(value);
}

void Calculator::removeCalculator(GeneralStack &stack)
{
    this->stack.removeStack();
}
