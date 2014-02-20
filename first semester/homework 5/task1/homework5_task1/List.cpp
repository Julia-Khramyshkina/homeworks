#include "List.h"
#include <stdlib.h>
#include <string.h>
#include <iostream>

using namespace std;

struct List
{
	NumberType numbers[100];
	NameType names[100];
	Position last;
};

List *create()
{
	List *result = new List;
	result->last = -1;
	for (int i = 0; i < 100; ++i) {
		result->names[i] = new char[255];
	}
	return result;
}

void insert(List *list, NameType who, NumberType phone)
{
	list->last = list->last + 1;
	list->numbers[list->last] = phone;
	strcpy(list->names[list->last], who);
}

Position meanWithoutNumber(List *list, NameType who)
{
	for (Position i = 0; i < list->last; ++i)
	{
		if  (strcmp(who, list->names[i])  == 0)
		{
			return i;
		}
	}
	return -100;
}

bool badmeanWithoutNumber(List *list, NameType who)
{
	Position badNumberresult = meanWithoutNumber (list, who);
	return badNumberresult != -100;
}

Position meanWithoutName(List *list, NumberType phone)
{
	for (Position i = 0; i < list->last; ++i)
	{
		if  (list->numbers[i] == phone)
		{
			return i;
		}
	}
	return -100;
}

bool badMeanWithoutName(List *list, NumberType phone)
{
	Position badMeanWithoutName = meanWithoutName (list, phone);
	return badMeanWithoutName != -100;
}

NumberType getNumber (List *list,  NameType who)
{
	Position positionOfName = meanWithoutNumber (list, who);
	return list->numbers[positionOfName];
}

NameType getName(List *list, NumberType phone)
{
	Position positionOfNumber = meanWithoutName (list, phone);
	return list->names[positionOfNumber];
}

void deleteList(List *list)
{
	Position i = 0;
	while (i <= list->last)
	{
		delete list->names[i];
		++i;
	}
	delete list;
}