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

void insertToHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

void insertToEnd(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = NULL;
	if (first(list) != end(list))
	{
		Position positionOfInsert = previous(list, end(list));
		positionOfInsert->next = newElement;
	}
	else
	{
		insertToHead(list, value);
	}

}

int sizeOfList(List *list)
{
	int countOfElements = 0;
	Position count = first(list);
	while (count != end(list))
	{
		++countOfElements;
		count = count->next;
	}

	return countOfElements;
}

void remove(List *list, Position position)
{
	if (position == list->head)
	{
		list->head = list->head->next;
		delete position;
		return;
	}
	Position search = list->head;
	while (search->next != position)
	{
		search = search->next;
	}
	search->next = position->next; 
	Position temp = position;
	delete position;
}

void print(List *list)
{
	Position positionTemp = list->head;
	while (positionTemp != NULL)
	{
		cout << positionTemp->value.name << endl;
		cout << positionTemp->value.number << endl;
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

Position previous(List *list, Position position)
{
	Position search = list->head;
	while (search->next != position)
	{
		search = search->next;
	}
	return search;
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
