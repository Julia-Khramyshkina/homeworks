#pragma once
#include "stackwitharray.h"
#include <QTextStream>

StackWithArray::StackWithArray()
{
}

StackWithArray::~StackWithArray ()
{
    delete [] value;
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
        throw QString("Stack is empty");
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
