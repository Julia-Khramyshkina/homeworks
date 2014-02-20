#include <stdlib.h>
#include "list.h"
#include "listMas.h"
#include <iostream>
#include <fstream>
#include "mergeSort.h"

using namespace std;
using namespace list;

int main()
{
	List *list = create();
	Direction ourDirection;
	int input = 1;
	fstream file("direction.txt");
	int number = 0;

	while(!file.eof())
	{
		file >> number;
		ourDirection.numbers = number;
		char lastName[50];
		file >> lastName;
		strcpy(ourDirection.names, lastName);	
		if (file.eof())
		{
			break;
		}
		insertToEnd(list, ourDirection);
	}
	file.close();
		
	if (first(list) == end(list))
	{
		cout << "Sorry, file is empty" << endl;
		deleteList(list);
		return 0;
	}
	cout << "Please select the command" << endl;
	cout << "Sort by name: 1" << endl;
	cout << "Sort by number: 0" << endl;

	bool criterion = true;
	cout << "Command: ";
	cin >> criterion;

	List *sortedList = mergeSort(list, criterion);
	cout << "\nSorted direction" << endl;
	print(sortedList);
	deleteList(list);
	deleteList(sortedList);
	return 0;
}