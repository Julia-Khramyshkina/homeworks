#include <QtCore/QDebug>
#include "generalstack.h"
#include "calculator.h"
#include "stackwitharray.h"
#include "stack.h"
#include <QTextStream>

int main()
{
    GeneralStack *stack = new Stack();
    Calculator *calculator = new Calculator(*stack);
    QTextStream in(stdin);
    QString outString;
    outString = in.readLine();
    int i = 0;
    while (outString[i] != '=')
    {
        if (outString[i] >= '0' && outString[i] <= '9')
        {
            int number = QString(outString[i]).toInt();
            calculator->pushResult(number);
        }
        else
        {
            calculator->operation(outString[i]);
        }
        ++i;
    }
    qDebug() << calculator->popValue();
    delete stack;
    delete calculator;
}
