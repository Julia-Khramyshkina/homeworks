#pragma once

typedef int ElementType;

// �������� ������������ ������ � ��� �����
struct List;
struct ListElement;

typedef ListElement *Position;

// ����� ����������� ������, ������� ��� ������
List *create();

void insert(List *list, ElementType value);

// ����� ����, ��� ������ �������
void findTheThatGuysWhoMustDie(List *list, ElementType theNumberOfDeath, ElementType theNumberOfSoldiers);

// ����������� ������� ����, ��� ������ �������, ������������ ������ � ����� ������
void deleteElement(List *list, Position badPosition);

// ���������� ��������
void deleteContinue(List *list, Position temp, Position counter);

// ����� ������
void printAnswer(List *list);