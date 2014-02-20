#pragma once

// создание типа эквивалентного типу int
typedef int ElementType;

// объявление стека
struct Stack;

// создание стека
Stack *create();

// положить в стек
void push(Stack* stack, ElementType value);

// извлечь из стека
ElementType pop(Stack* stack);

// очистить стек
void clearStack(Stack* stack);