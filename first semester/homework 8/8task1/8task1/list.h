#pragma once


namespace list
{

// ���������� ��������� ��� �������� ����� � ��� �����
struct Word
{
	char* newWord;
	int length;
};

typedef Word ElementType;

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

// ������� �������� � ������ �������
void insertToHead(List *list, ElementType value);

// �������� �������� �� ������� �������
void remove(List *list, Position position);

// �������� ������������� ��������
bool exist(List *list, ElementType value);

// ��������� ������� �������� �� ��� ��������
Position positionOfElement(List *list, ElementType value);

// ���������� ����
void printWords(List *list);

// �������� ������ �� �������
bool empty (List *list);

// ���������� �������� ������ �� ����� ��������
void increase(List *list, ElementType value);
}