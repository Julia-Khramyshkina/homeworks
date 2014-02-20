#pragma once

typedef int ElementType;

struct Queue;

Queue* createQueue();
void remove(Queue* queue);
void insertToTheEnd(Queue* queue, ElementType value);
ElementType removeFromHead(Queue* queue);
bool isEmpty(Queue* queue);