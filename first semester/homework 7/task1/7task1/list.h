#pragma once
namespace list
{
// появление структуры
struct Direction
{
	char names[50];
	int numbers;
};

typedef Direction ElementType;

// появление списка
struct List;
struct ListElement;
typedef ListElement *Position;

// явное предъявление списка
List *create();

// операция вставки в конец списка
void insertToEnd(List *list, ElementType value);

// распечатка списка
void print(List *list);

Position first(List *list);
Position end(List *list);
Position next(List *list, Position position);
Position previous(List *list, Position position);

// размер списка
int sizeOfList (List *list);

// выдача значения по позиции
ElementType valueOnPosition(List *list, Position Position);

// очистка совести ^W памяти
void deleteList(List *list);

void insertToHead(List *list, ElementType value);

void remove(List *list, Position position);
}