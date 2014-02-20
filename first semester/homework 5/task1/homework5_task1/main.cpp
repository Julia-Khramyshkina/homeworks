#include <stdlib.h>
#include "List.h"
#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string.h>

using namespace std;

int main()
{
	List *list = create();
	fstream directoryInput ("directory.txt", ios::in);
	char someone[255]; 
	int numberOfSomeone = -1;
	cout << "Hello! Please change the command \n";
	cout << "0 - exit\n";
	cout << "1 - add record in direcory \n";
	cout << "2 - find the number \n";
	cout << "3 - find the name  \n";

	if (directoryInput.is_open ()) 
	{
		while (!directoryInput.eof()) 
		{
			directoryInput >> numberOfSomeone;
			directoryInput >> someone;
			if (!directoryInput.eof()) 
			{
				insert(list, someone, numberOfSomeone);
			}
		}
	}
	directoryInput.close();

	fstream directory ("directory.txt", ios::app);
	int inputInteractive = -1;
	while (inputInteractive != 0)
	{
		bool control = false;
		cout << "Please input the command \n";
		cin >> inputInteractive;
		if (inputInteractive == 1)
		{
			cout << "Please input number  \n";	
			cin >> numberOfSomeone;
			cout << "Please input name  \n";
			cin >> someone;
			insert(list, someone, numberOfSomeone);
			directory << numberOfSomeone << " ";
			directory << someone << endl;
			control = true;
		}
		if (inputInteractive == 2)
		{
			cout << "Please input name  \n";
			cin >> someone;
			bool badOrGood = badmeanWithoutNumber(list, someone);
			if (badOrGood)
			{
				numberOfSomeone = getNumber(list, someone);
				cout << " The number: " << numberOfSomeone << endl;
			}
			else
			{
				cout << "Sorry, this man isn't exist! \n";
			}
			control = true;
		}
		if (inputInteractive == 3)
		{
			cout << "Please input number  \n";
			cin >> numberOfSomeone;
			bool badOrGood = badMeanWithoutName(list, numberOfSomeone);
			if (badOrGood)
			{
				strcpy(someone, getName(list, numberOfSomeone));
				cout << "This is " << someone << endl;
			}
			else
			{
				cout << "Sorry, this number isn't exist! \n";
			}
			control = true;
		}
		if (inputInteractive == 0)
		{
			deleteList(list);
			directory.close();
			return 0;
		}
		if (!control)
		{
			cout << "Uncorrect input  \n";
			deleteList(list);
			directory.close();
			return 0;
		}
	}		
	return 0;
}