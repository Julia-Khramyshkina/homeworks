#pragma once

// �������� ���� �������������� ���� int
typedef char ElementTypeStack;

// ��������� ����� � ��� ����������� ��������
struct Stack;
Stack *createStack();

// �������� � ����
void push(Stack* &stack, ElementTypeStack value);

// ������� �� �����
ElementTypeStack pop(Stack* &stack);

// �������� ����
void clearStack(Stack* &stack);

bool empty(Stack* &stack);