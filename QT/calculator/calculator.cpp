#pragma once
#include "calculator.h"

    void Calculator:: operation(QCharRef something)
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
            int number1 = this->popValue();
            int number2 =  this->popValue();
            this->pushResult(number2 / number1);
        }
   }

    int Calculator:: popValue()
    {
        return this->stack.pop();
    }

    void Calculator:: pushResult(int value)
    {
        this->stack.push(value);
    }

    void Calculator::removeCalculator(GeneralStack &stack)
    {
        this->stack.removeStack();
        delete this;
    }
