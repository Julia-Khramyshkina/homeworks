#include <stdlib.h>
#include "stack.h"
#include "queue.h"
#include <iostream>

using namespace std;

int op_preced(char c)
{
    switch(c)
    {
 
        case '*':
        case '/':
        return 3;
 
        case '+':
        case '-':
        return 2;
 
        case '=':
        return 1;
    }
    return 0;
}

int main()
{
	Stack *stack = createStack();
	Queue *queue = createQueue();


	char something = ' ';
	char early = ' ';

	while (something != '=')
	{
		cin >> something;
		if (something >= '0' && something <= '9')
		{
			insertToTheEnd(queue, something);
			while (!empty(stack))
			{
				something = pop(stack);
				insertToTheEnd(queue, something);
			}
		}
		if (something == '+' || something == '-')
		{
			push(stack, something);
			early = something;

		}
		if (something == '(')
		{
			push(stack, something);
		}
		if (something == ')')
		{
			while (something != '(')
			{
				something = pop(stack); 
				insertToTheEnd(queue, something);
			}
		}
		if (something == '*' || something == '/')
		{
			push(stack, something);
		}
	}