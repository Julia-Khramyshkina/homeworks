#pragma once
#include "stack.h"

Stack::Stack()
{
}
Stack:: ~Stack()
{
    this->removeStack();
}

    void Stack::push(int value)
    {
        StackElement *temp = new StackElement;
        temp->value = value;
        temp->next = this->head;
        this->head = temp;
    }

    int Stack::pop()
    {
        int thisValue = this->head->value;
        StackElement *temp = this->head;
        this->head = this->head->next;
        delete temp;
        return thisValue;
    }

    void Stack:: removeStack()
    {
        while (this->head != nullptr)
        {
            this->pop();
        }
    }
