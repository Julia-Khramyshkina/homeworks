#pragma once

///
/// \brief The GeneralStack class
///
class GeneralStack
{
public:
    GeneralStack();
    virtual ~GeneralStack() {}
    ///
    /// \brief pop
    /// \return
    ///
    virtual int pop() = 0;

    ///
    /// \brief push
    /// \param value
    ///
    virtual void push(int value) = 0;

    ///
    /// \brief removeStack
    ///
    virtual void removeStack() = 0;
};
