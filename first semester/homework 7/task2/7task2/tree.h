#pragma once

typedef int Element;

// ���������� ������
struct Tree;

// �������� ������
Tree *create();

// �������� ������
void remove(Tree *tree);

// ������� �������� � ������
void insertElement(Tree *tree, Element value);

// �������� �������� �� ������
void removeElement(Tree *tree, Element value);

// �������� ������������� ��������
bool exists(Tree *tree, Element value);

// ����� ��������� ������ �� �����������
void printAscending(Tree *tree);

// ����� ��������� ������ �� ��������
void printDescending(Tree *tree);

// �������� ������ �� �������
bool emptyTree(Tree *tree);
