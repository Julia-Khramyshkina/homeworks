#include <stdlib.h>
#include "list.h"
#include <iostream>

using namespace std;

int main()
{
	List *list = create();
	cout << "Hello! Please change the command \n";
	cout << "0 - exit\n";
	cout << "1 - add value in the sorted list \n";
	cout << "2 - remove value from list \n";
	cout << "3 - print list \n";
	int inputInteractive = -1;
	bool firstElement = true;

	while (inputInteractive != 0)
	{
		bool control = false;
		cout << "Please input the command \n";
		cin >> inputInteractive;
		if (inputInteractive == 1)
		{
			ElementType newValue = 0;
			cin >> newValue;
			
			Position temp = first(list);
			while (temp != end(list) && !firstElement)
			{
				if (next(list, temp) != end(list))
				{
					if (newValue > valueOnPosition(list, temp) && newValue < valueOnPosition(list, next(list, temp)) )  
					{
						insert(list, newValue, temp);
						control = false;
						break;
					}
					temp = next(list, temp);
				}
				else break;
			}

			if (!control && !firstElement)
			{
				if (newValue > valueOnPosition(list, first(list)) )
				{
					insert(list, newValue, temp);
					control = false;
				}
			}
			if (!control && !firstElement)
			{
				insertToHead(list, newValue);
				control = false;
			}
			if (firstElement)
			{
				insertToHead(list, newValue);
				firstElement = false;
			}
		}
		if (inputInteractive == 2)
		{
			cout << "Please input value for delete\n";
			ElementType deleteValue = 0;
			cin >> deleteValue;
			for (Position temp = first(list); temp != end(list); temp = next(list, temp))
			{
				if (deleteValue == valueOnPosition(list, temp))
				{
					remove(list, temp);
				}
			}
		}
		if (inputInteractive == 3)
		{
			cout << "Our sorted list\n";
			print(list);
		}
	}
	return 0;
}