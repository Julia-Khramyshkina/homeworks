#include <stdlib.h>
#include "list.h"
#include <iostream>
#include <fstream>

using namespace std;

Position middle(List *list, Position left, Position right)
{
	int countOfElements = 0;
	Position i = left;
	while (i != right)
	{
		++countOfElements;
		i = next(list, i);
	}

	Position needMiddlePosition = left;
	for (int j = 0; j < countOfElements / 2 - 1; ++j)
	{
		needMiddlePosition = next(list, needMiddlePosition);
	}
	return needMiddlePosition;
}

bool regulation(ElementType direction1, ElementType direction2, bool criterion)
{
	if (criterion)
	{
		if (strcmp(direction1.name, direction2.name) <= 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	else 
	{
		if (direction1.number < direction2.number)
		{
			return true;
		}
		else 
		{
			return false;
		}
	}
}

List *merge(List *list1, List *list2, bool criterion)
{
	Position pos1 = first(list1);
	Position pos2 = first(list2);
	List *result = create();
	while (pos1 != end(list1) && pos2 != end(list2))
	{
		if (regulation(valueOnPosition(list1, pos1), valueOnPosition(list2, pos2), criterion))
		{
			insertToEnd(result, valueOnPosition(list1, pos1));
			pos1 = next(list1, pos1);
		}
		else
		{
			insertToEnd(result, valueOnPosition(list2, pos2));
			pos2 = next(list2, pos2);
		}
	}

	while (pos2 != end(list1)) 
	{
		insertToEnd(result, valueOnPosition(list2, pos2));
		pos2 = next(list2, pos2);
	}

	while (pos1 !=  end(list2))
	{
		insertToEnd(result, valueOnPosition(list1, pos1));
		pos1 = next(list1, pos1);
	}
	
	return result;
}

List *mergeSort(List *list,bool criterion)
{
	if (sizeOfList(list) > 1)
	{
		Position middleAtTheMoment = middle(list, first(list), end(list));
		List *tempList1 = create();
		List *tempList2 = create();
		Position positionAtTheMoment = first(list);
		while (positionAtTheMoment != next(list, middleAtTheMoment))
		{
			insertToEnd(tempList1, valueOnPosition(list, positionAtTheMoment));
			positionAtTheMoment = next(list, positionAtTheMoment);
		}
		
		while (positionAtTheMoment != end(list))
		{
			insertToEnd(tempList2, valueOnPosition(list, positionAtTheMoment));
			positionAtTheMoment = next(list, positionAtTheMoment);
		}
		
		List *sortedTempList1 = mergeSort(tempList1, criterion);
		deleteList(tempList1);
		List *sortedTempList2 = mergeSort(tempList2, criterion);
		deleteList(tempList2);

		List *resultList = merge(sortedTempList1, sortedTempList2, criterion);
		
		deleteList(sortedTempList1);
		deleteList(sortedTempList2);

		return resultList;
	}
	else
	{
		List *copyResultList = create();
		insertToEnd(copyResultList, valueOnPosition(list, first(list)));
		return copyResultList;
	}	
}

int main()
{
	List *list = create();
	Direction ourDirection;
	int input = 1;
	fstream file("direction.txt");
	while(!file.eof())
	{
		char lastName[50];
		file >> lastName;
		strcpy(ourDirection.name, lastName);
		int number = 0;
		file >> number;
		ourDirection.number = number;
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