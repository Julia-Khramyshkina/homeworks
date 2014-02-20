#include <stdlib.h>
#include "stack.h"
#include <iostream>

using namespace std;

void operation(char something, Stack *&stack)
{
	switch (something)
	{ 
		case '+' :
		{
			push(stack, pop(stack) + pop(stack));						
			break;
		}
		case '-' :
		{
			push(stack, -pop(stack) + pop(stack));						
			break;
		}
		case '*' :
		{
			push(stack, pop(stack) * pop(stack));						
			break;
		}
		case '/' :
		{
			int number1 = pop(stack);
			int number2 = pop(stack);
			push(stack, number2 / number1);						
			break;
		}
	}
}

int main()
{
	Stack *stack = create();
	char something = ' ';
	cout << "Please input arithmetic expression" << endl;
	cin >> something;
	while (something != '=')
	{
		if (something >= '0' && something <= '9')
		{
			int number = something - 48;
			push(stack, number);
		}
		else 
		{
			operation(something, stack);
		}
		cin >> something;
	}
	cout << "Result " << pop(stack) << endl;
	clearStack(stack);
	return 0;
}