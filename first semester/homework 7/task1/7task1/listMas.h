#pragma once
namespace listMas
{

typedef int NumberType;
typedef char* NameType;
typedef int Position;

struct List;

//typedef List ElementType;

struct Direction
{
	char names[50];
	int numbers;
};

typedef Direction ElementType;

List *create();

void insert(List *list, NameType who, NumberType phone);

bool badmeanWithoutNumber (List *list, NameType who);
NumberType getNumber (List *list,  NameType who);

bool badmeanWithoutName (List *list, NumberType phone);
NameType getName (List *list, NumberType phone);

Position next(List *list, Position position);
void insertToHead(List *list, ElementType value);

void insertToEnd(List *list, ElementType value);


int sizeOfList(List *list);
Position first(List *list);
	
Position end(List *list);

ElementType valueOnPosition(List *list, Position position);

void deleteList(List *list);

void print(List *list);
}