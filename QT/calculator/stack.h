#pragma once
#include "generalstack.h"

///
/// \brief The Stack class
///
class Stack : public GeneralStack
{
public:
    Stack();
    ~Stack();
    ///
    /// \brief push
    /// \param value
    ///
    void push(int value) override;

    ///
    /// \brief pop
    /// \return
    ///
    int pop() override;

    ///
    /// \brief removeStack
    ///
    void removeStack() override;


private:
    ///
    /// \brief The StackElement class
    ///
    class StackElement
    {
    public:
        int value;
        StackElement *next;
    };
    StackElement *head = nullptr;
};




