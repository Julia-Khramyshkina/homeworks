#pragma once

// создание типа эквивалентного типу int
typedef char ElementType;

// появление стека и его фактическое создание
struct Stack;
Stack *create();

// положить в стек
void push(Stack* &stack, ElementType value);

// извлечь из стека
ElementType pop(Stack* &stack);

// очистить стек
void clearStack(Stack* &stack);