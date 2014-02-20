#include "list.h"
#include <stdlib.h>
#include <string.h>
#include <iostream>

using namespace std;

struct ListElement
{
	ElementType value;
	ListElement *next;
};

struct List
{
	ListElement *head;
};

List *create()
{
	List *result = new List;
	result->head = NULL;
	return result;
}

void insert(List *list, ElementType value, Position position)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = position->next;
	position->next = newElement;
}

void insertToHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

void remove (List *list, Position position)
{
	if (position->next == NULL)
	{
		cout << "You are stupid" << endl;
		return;
	}

	Position temp = position->next;
	position->next = position->next->next;
	delete temp;
}

void print(List *list)
{
	Position positionTemp = list->head;
	while (positionTemp != NULL)
	{
		cout << positionTemp->value << endl;
		positionTemp = positionTemp->next;

	}
}

Position first(List *list)
{
	return list->head;
}

Position end(List *list)
{
	return NULL;
}

Position next(List *list, Position position)
{
	return position->next;
}

ElementType valueOnPosition(List *list, Position position)
{
	return position->value;
}

void deleteList(List *list)
{
	ListElement *i = list->head;
	while (i != NULL)
	{
		ListElement *temp = i;
		i = i->next;
		delete temp;
	}
	delete list;
}