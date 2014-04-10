#pragma once
#include "generalstack.h"

/// Class ordinary stack
class Stack : public GeneralStack
{
public:
    Stack();
    ~Stack();

    /// Push value to stack
    void push(int value) override;

    /// Pop value from stack
    int pop() override;

    /// Remove stack
    void removeStack() override;

private:
    /// Class for element of stack
    class StackElement
    {
    public:
        int value;
        StackElement *next;
    };
    StackElement *head = nullptr;
};




