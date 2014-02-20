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
	ListElement *head, *tail;
};

List *create()
{
	List *result = new List;
	ListElement *guard = new ListElement;
	guard = NULL;
	result->head = result->tail = guard;
	return result;
}

void insert(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	if (list->head != nullptr)
	{
		list->tail->next = newElement;
		list->tail = newElement;
	}
	else
	{
		list->head = list->tail = newElement;
	}
}

void deleteContinue(List *list, Position temp, Position counter)
{
	temp = counter->next;
	counter->next = counter->next->next;
	delete temp;
}

void deleteElement(List *list, Position badPosition)
{
	Position counter = list->head;
	Position temp = counter->next;

	while ((counter->next != list->head) && (counter->next != badPosition))
	{
		counter = counter->next;
	}

	if ((counter->next != list->head) && (counter->next != list->tail))
	{
		deleteContinue(list, temp, counter);
		return;
	}

	if (counter->next == list->head)
	{
		list->head = counter->next->next;
		deleteContinue(list, temp, counter);
		return;
	}

	if (counter->next == list->tail)
	{
		list->head = counter->next->next;
		Position search = list->head;
		while (search->next != list->tail)
		{
			search = search->next;
		}
		list->tail = search;
		deleteContinue(list, temp, counter);
		return;
	}
}

void findTheThatGuysWhoMustDie(List *list, ElementType theNumberOfDeath, ElementType theNumberOfSoldiers)
{
	int counter = 1;
	Position temp = list->head;
	while (list->head->value != list->tail->value)
	{
		if (counter == theNumberOfDeath)
		{
			counter = 1;
			Position copyTemp = temp->next;
			deleteElement(list, temp);
			temp = copyTemp;
			continue;
		}
		++counter;
		temp = temp->next;
	}
}

void printAnswer(List *list)
{
	Position positionTemp = list->head;
	cout << positionTemp->value << endl;
}