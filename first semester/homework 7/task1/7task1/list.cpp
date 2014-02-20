#include "list.h"
#include <stdlib.h>
#include <string.h>
#include <iostream>

using namespace std;


struct list::ListElement
{
	ElementType value;
	ListElement *next;
};

struct list::List
{
	ListElement *head;
};

list::List *list::create()
{
	List *result = new List;
	result->head = NULL;
	return result;
}

void list::insertToHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

void list::insertToEnd(List *list, ElementType value)
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

int list::sizeOfList(List *list)
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

void list::remove(List *list, Position position)
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

void list::print(List *list)
{
	Position positionTemp = list->head;
	while (positionTemp != NULL)
	{
		cout << positionTemp->value.names << endl;
		cout << positionTemp->value.numbers << endl;
		positionTemp = positionTemp->next;
	}
}

list::Position list::first(List *list)
{
	return list->head;
}

list::Position list::end(List *list)
{
	return NULL;
}

list::Position list::previous(List *list, Position position)
{
	Position search = list->head;
	while (search->next != position)
	{
		search = search->next;
	}
	return search;
}

list::Position list::next(List *list, Position position)
{
	return position->next;
}

list::ElementType list::valueOnPosition(List *list, Position position)
{
	return position->value;
}

void list::deleteList(List *list)
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
