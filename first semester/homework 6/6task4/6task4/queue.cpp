
#include "queue.h"
#include <stdlib.h>
#include <iostream>

using namespace std;

struct ElementOfQueue
{
	ElementType value;
	ElementOfQueue *next;
};

struct Queue
{
	ElementOfQueue *head;
	ElementOfQueue *last;
};

Queue* createQueue()
{
	Queue *result = new Queue;
	result->head = NULL;
	result->last = NULL;
	return result;
}

bool isEmpty(Queue* queue)
{
	return (queue->head == NULL) && (queue->last == NULL);
}

void insertToTheEnd(Queue* queue, ElementType value)
{
	ElementOfQueue *newElement = new ElementOfQueue;
	newElement->value = value;
	newElement->next = NULL;
	if (queue->last == NULL)
	{
		queue->last = newElement;
		queue->head = newElement;
	}
	queue->last->next = newElement;
	queue->last = queue->last->next;
//	queue->last = newElement;
}

ElementType removeFromHead(Queue* queue)
{
	ElementOfQueue *newHead = queue->head;
	if (queue->head == NULL)
	{
		cout << "Queue is empty" << endl;
		return 0;
	}
	queue->head = queue->head->next;
	if (queue->head == NULL)
	{
		queue->last = NULL;
	}
	ElementType value = newHead->value;
	delete newHead;
	return value;
}

void remove(Queue* queue)
{
	while (!isEmpty(queue))
	{
		removeFromHead(queue);
	}
	delete queue;
}
