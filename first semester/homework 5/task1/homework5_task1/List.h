#pragma once

// �������� ������������ �����
typedef int NumberType;
typedef char* NameType;
typedef int Position;

// �������� ��������� ������
struct List;

// ������� ��� �������� ������ ������ 
List *create();

// ������� ������� ��������� ������ � ������
void insert(List *list, NameType who, NumberType phone);

// �������� ������������� ������ � �������� ������
bool badmeanWithoutNumber(List *list, NameType who);

// ��������� ������ �� �����
NumberType getNumber(List *list,  NameType who);

// �������� ������������� ����� � �������� �������
bool badMeanWithoutName(List *list, NumberType phone);

// ��������� ����� �� ������
NameType getName(List *list, NumberType phone);

// �������� ������
void deleteList(List *list);