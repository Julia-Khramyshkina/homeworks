#include "listMas.h"
#include <stdlib.h>
#include <string.h>
#include <iostream>

using namespace std;

struct listMas::List
{
	NameType names[100];
	NumberType numbers[100];	
	Position last;
};

listMas::List *listMas::create()
{
	List *result = new List;
	result->last = -1;
	for (int i = 0; i < 100; ++i) {
		result->names[i] = new char[255];
	}
	return result;
}

void listMas::insert(List *list, NameType who, NumberType phone)
{
	list->last = list->last + 1;
	list->numbers[list->last] = phone;
	strcpy(list->names[list->last], who);
}

listMas::Position meanWithoutNumber (listMas::List *list, listMas::NameType who)
{
	for (listMas::Position i = 0; i < list->last; ++i)
	{
		if  (strcmp(who, list->names[i])  == 0)
		{
			return i;
		}
	}
	return -100;
}

bool listMas::badmeanWithoutNumber (List *list, NameType who)
{
	Position badNumberresult = meanWithoutNumber (list, who);
	if (badNumberresult != -100)
	{
		return true;
	}
	else
	{
		return false;
	}
}

listMas::Position meanWithoutName (listMas::List *list, listMas::NumberType phone)
{
	for (listMas::Position i = 0; i < list->last; ++i)
	{
		if  (list->numbers[i] == phone)
		{
			return i;
		}
	}
	return -100;

}

bool listMas::badmeanWithoutName (List *list, NumberType phone)
{
	Position badmeanWithoutName = meanWithoutName (list, phone);
	if (badmeanWithoutName != -100)
	{
		return true;
	}
	else
	{
		return false;
	}
}

listMas::NumberType listMas::getNumber (List *list,  NameType who)
{
	Position positionOfName = meanWithoutNumber (list, who);
	return list->numbers[positionOfName];
}

listMas::NameType listMas::getName (List *list, NumberType phone)
{
	Position positionOfNumber = meanWithoutName (list, phone);
	return list->names[positionOfNumber];

}
listMas::Position listMas::next(List *list, Position position)
{
	return ++position;
}

void listMas::insertToHead(List *list, ElementType value)
{
	list->last = list->last + 1;
	list->numbers[0] = value.numbers;
	strcpy(list->names[0], value.names);
	
}

void listMas::insertToEnd(List *list, ElementType value)
{
	list->last = list->last + 1;
	list->numbers[list->last] = value.numbers;
	strcpy(list->names[list->last], value.names);

}

int listMas::sizeOfList(List *list)
{
	return list->last + 1;
}

listMas::Position listMas::first(List *list)
{ 
	return 0;
}

listMas::Position listMas::end(List *list)
{
	return list->last + 1;
}

listMas::ElementType listMas::valueOnPosition(List *list, Position position)
{
	ElementType currentValue;
	strcpy(currentValue.names, list->names[position]);
	currentValue.numbers = list->numbers[position];

	return currentValue;
}

void listMas::deleteList(List *list)
{
	while (list->last >= 0)
	{
		delete list->names[list->last];
		--list->last;
	}
	delete list;
}

void listMas::print(List *list)
{
	int positionTemp = 0;
	while (positionTemp != list->last + 1)
	{
		cout << list->names[positionTemp] << endl;
		cout << list->numbers[positionTemp] << endl;
		++positionTemp;
	}
}