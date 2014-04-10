#pragma once

/// Interface for stack
class GeneralStack
{
public:
    /// Pop value from stack
    virtual int pop() = 0;

    /// Push value to stack
    virtual void push(int value) = 0;

    /// Remove stack
    virtual void removeStack() = 0;
};
