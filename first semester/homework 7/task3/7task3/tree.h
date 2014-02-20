#pragma once

typedef char Element;

// ���������� ������
struct Tree;
struct ElementOfTree;
typedef ElementOfTree *Position;
// �������� ������
Tree *create();

// �������� ������
void remove(Tree *tree);

// ������� �������� � ������
void insertElement(Tree *tree, char* stringOfFile, int &i, Position position);

// �������� �������� �� ������
void removeElement(Tree *tree, Element value);

// �������� ������������� ��������
bool exists(Tree *tree, Element value);

// ����� ��������������� ���������
void printArithmeticExpression(Tree *tree);

// �������� ������ �� �������
bool emptyTree(Tree *tree);

// ������ ���������� �������� �� �������� ���, ��� ��� ����������
void changeInTree(Tree *tree, Position position);

// ������� �������� ���������
int count(Tree *tree, Position position, Position preposition);

// ������ ������� ������
Position first(Tree *tree);
