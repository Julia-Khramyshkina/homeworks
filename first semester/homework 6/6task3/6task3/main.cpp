#include <stdlib.h>
#include "stack.h"
#include <iostream>

using namespace std;

int main()
{
	Stack *stack = create();
	char something = ' ';
	char previous = 'a';
	cout << "Please input sequence" << endl;
	while (something != '0')
	{
		cin >> something;
		if (something == '(' || something == '{' || something == '[')
		{
			push(stack, something);
		}
		if (something == ')' || something == '}' || something == ']')
		{
			previous = pop(stack);
			if (something == ')' && previous != '(' || something == ']' && previous != '[' || something == '}' && previous != '{')
			{
				cout << "Sequence is incorrect" << endl;
				break;
			}
		}
	}
	if (something == '0') 
	{
		cout << "Sequence is correct" << endl;
		return 0;
	}
	clearStack(stack);
	return 0;
}