#include "stack.h"
#include <iostream>

using namespace std;

struct ListElement
{
	ElementType value;
	ListElement *next;
};

struct Stack
{
    ListElement *head;
};

Stack *create()
{
	Stack *stack = new Stack;
	stack->head = nullptr;
	return stack;
}
 
void push(Stack* &stack, ElementType value)
{
	ListElement *temp = new ListElement;     
	temp->value = value;  
	temp->next = stack->head;      
	stack->head = temp; 	              
}

ElementType pop(Stack* &stack)
{  
	ElementType thisValue = stack->head->value;    
	ListElement *temp = stack->head;      
	stack->head = stack->head->next;     
    delete temp;              
    return thisValue;           
}

void clearStack(Stack* &stack)
{
	while (stack->head != nullptr)
	{
		pop(stack);
	}
	delete stack;
}