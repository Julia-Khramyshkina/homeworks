#pragma once
#include "generalstack.h"
#pragma once
#include "generalstack.h"

///
/// \brief The StackWithArray class
///
class StackWithArray : public GeneralStack
{
public:
    StackWithArray();
    ~StackWithArray();


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

    ///
    /// \brief isEmpty
    /// \return
    ///
    bool isEmpty();


private:
    int *value = new int [100];
    int head = -33333;
};
