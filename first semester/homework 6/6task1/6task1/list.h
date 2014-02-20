#pragma once

// ��������� ���������
struct Direction
{
	char name[50];
	int number;
};

typedef Direction ElementType;

// ��������� ������
struct List;
struct ListElement;
typedef ListElement *Position;

// ����� ������������ ������
List *create();

// �������� ������� � ����� ������
void insertToEnd(List *list, ElementType value);

// ���������� ������
void print(List *list);

Position first(List *list);
Position end(List *list);
Position next(List *list, Position position);
Position previous(List *list, Position position);

// ������ ������
int sizeOfList (List *list);

// ������ �������� �� �������
ElementType valueOnPosition(List *list, Position Position);

// ������� ������� ^W ������
void deleteList(List *list);