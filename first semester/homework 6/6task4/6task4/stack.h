#pragma once

// создание типа эквивалентного типу int
typedef char ElementTypeStack;

// появление стека и его фактическое создание
struct Stack;
Stack *createStack();

// положить в стек
void push(Stack* &stack, ElementTypeStack value);

// извлечь из стека
ElementTypeStack pop(Stack* &stack);

// очистить стек
void clearStack(Stack* &stack);

bool empty(Stack* &stack);