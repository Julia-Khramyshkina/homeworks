#pragma once
#include "stackwitharray.h"
StackWithArray::StackWithArray()
{
}

StackWithArray::~StackWithArray ()
{
    this->removeStack();
}
    void StackWithArray:: push(int value)
    {
        ++this->head;
        this->value[head] = value;
    }

    bool StackWithArray:: isEmpty()
    {
        return (this->head == -1);
    }

    int StackWithArray::pop()
    {
        if (this->isEmpty())
        {
            return -33333;
        }
        int temp = this->value[head];
        this->value[head] = 0;
        --this->head;
        return temp;
    }

    void StackWithArray:: removeStack()
    {
        while (!this->isEmpty())
        {
            this->pop();
        }
    }
