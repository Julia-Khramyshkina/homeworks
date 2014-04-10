#pragma once
#include "generalstack.h"

/// Class Stack with array
class StackWithArray : public GeneralStack
{
public:
    StackWithArray();
    ~StackWithArray();

    /// Push value to stack
    void push(int value) override;

    /// Pop value from stack
    int pop() override;

    /// Remove stack
    void removeStack() override;

    /// Checking. Empty?
    bool isEmpty();

private:
    int *value = new int [100];
    int head = -1;
};
