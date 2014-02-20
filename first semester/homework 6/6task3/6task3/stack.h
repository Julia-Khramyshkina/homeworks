#pragma once

// �������� ���� �������������� ���� int
typedef char ElementType;

// ��������� ����� � ��� ����������� ��������
struct Stack;
Stack *create();

// �������� � ����
void push(Stack* &stack, ElementType value);

// ������� �� �����
ElementType pop(Stack* &stack);

// �������� ����
void clearStack(Stack* &stack);