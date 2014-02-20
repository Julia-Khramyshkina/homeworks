#include "tree.h"
#include <iostream>

using namespace std;

struct ElementOfTree
{
	Element value;	
	int valueOfInt;
	ElementOfTree *left;
	ElementOfTree *right;
};

struct Tree
{
	ElementOfTree *head;
};

Tree *create()
{
	Tree *newTree = new Tree;
	newTree->head = nullptr;
	return newTree;
}

void removeSubTree(ElementOfTree *element)
{
	if (element != nullptr)
	{
		removeSubTree(element->left);
		removeSubTree(element->right);
		delete element;
	}
}

void remove(Tree *tree)
{
	removeSubTree(tree->head);	
	delete tree;
}

bool exists(Tree *tree, Element value)
{
	ElementOfTree *counter = tree->head;
	if (tree->head == nullptr)
	{
		return false;
	}

	while (counter != nullptr )
	{
		if (counter->value == value) 
		{
			return true;
		}
		if (value > counter->value)  
		{
			counter = counter->right;
		}
		else
		{
			counter = counter->left;
		}
	}
	return false;
}

void removeElement(Tree *tree, Element value)
{
	ElementOfTree *counter = tree->head;
	ElementOfTree *previousCounter = tree->head;
	if (exists(tree, value))
	{
		while (counter->value != value)
		{
			if (counter->value == value)
			{
				break;
			}
			if (counter->value < value)
			{
				counter = counter->right;
				if (previousCounter->right->value != value)
				{
					previousCounter = previousCounter->right;
				}
			}
			else
			{
				counter = counter->left;
				if (previousCounter->left->value != value)
				{
					previousCounter = previousCounter->right;
				}
			}
		}
	}

	if (counter->left == nullptr && counter->right == nullptr)
	{
		if (previousCounter->left == counter)
		{
			previousCounter->left = nullptr;
		}
		else
		{
			previousCounter->right = nullptr;
		}
		delete counter;
		return;
	}

	if (counter->left == nullptr && counter->right != nullptr)
	{
		if (previousCounter->left == counter)
		{
			previousCounter->left = counter->right;
		}
		else
		{
			previousCounter->right = counter->right;
		}

		return;
	}

	if (counter->left != nullptr && counter->right == nullptr)
	{
		if (previousCounter->left == counter)
		{
			previousCounter->left = counter->left;
		}
		else
		{
			previousCounter->right = counter->left;
		}
		return;
	}

	if (counter->left != nullptr && counter->right != nullptr)
	{
		ElementOfTree *searchCounter = counter->right;
		while (searchCounter->left != nullptr)
		{
			searchCounter = searchCounter->left;
		}
		Element temp = searchCounter->value;
		removeElement(tree, searchCounter->value);

		counter->value = temp;
		return;
	}
}

void printArithmeticExpressionDouble(ElementOfTree *currentElement)
{
	if (currentElement->value >= '0' && currentElement->value <= '9')
	{
		cout << currentElement->value << ' ';
	}
	else 
	{
		cout << "(" << currentElement->value << ' ';
	}

	if (currentElement->right != nullptr)
	{
		printArithmeticExpressionDouble(currentElement->right);		
	}

	if (currentElement->left != nullptr)
	{
		printArithmeticExpressionDouble(currentElement->left);
	}

	if (currentElement->value <= '0' || currentElement->value >= '9')
	{
		cout << ") ";
	}
	return;
}

void printArithmeticExpression(Tree *tree)
{
	printArithmeticExpressionDouble(tree->head);
}

bool emptyTree(Tree *tree)
{
	return (tree->head == nullptr);
}

ElementOfTree *createNewElement(char stringOfFile)
{
	ElementOfTree *temp = new ElementOfTree;
	temp->value = stringOfFile;
	temp->right = nullptr;
	temp->left = nullptr;
	return temp;
}

void insertElement(Tree *tree, char* stringOfFile, int &i, Position position)
{
	if (stringOfFile[i]  == '(')
	{
		++i;
		insertElement(tree, stringOfFile, i, position);
	}
	
	if (stringOfFile[i]  == ')')
	{
		++i;
		return;
	}

	if (stringOfFile[i - 1] == ')' && (stringOfFile[i] >= '9' || stringOfFile[i] <= '0') && stringOfFile[i] != '(')
	{
		return;
	}

	if (stringOfFile[i] == '+'|| stringOfFile[i] == '-' || stringOfFile[i] == '*' || stringOfFile[i] == '/')
	{
		if (tree->head == nullptr)
		{
			tree->head = createNewElement(stringOfFile[i]);
			position = tree->head;
			++i;
		}
		else
		{
			if (position->left == nullptr)
			{
				position->left = createNewElement(stringOfFile[i]);
				position = position->left;
				++i;
			}
			else
			{
				if (position->right == nullptr)
				{
					position->right = createNewElement(stringOfFile[i]);
					position = position->right;
					++i;
				}
				else
				{
					while (position->left != nullptr)
					{
						position = position->left;
					}
					position->left->value = stringOfFile[i];
					position = position->left;
					++i;
				}
			}
		}
	}
	if (stringOfFile[i] >= '0' && stringOfFile[i] <= '9')
	{
		if (position->left == nullptr)
		{
			position->left = createNewElement(stringOfFile[i]);
			++i;					
		}
		else
		{
			if (position->right == nullptr)
			{
				position->right = createNewElement(stringOfFile[i]);
				++i;
			}			
		}
	}
	insertElement(tree, stringOfFile, i, position);
}

Position first(Tree *tree)
{
	return tree->head;
}

void changeInTree(Tree *tree, Position position)
{
	if (position->value >= '0' && position->value <= '9')
	{
		position->valueOfInt = position->value - '0';
	}
	if (position->left != nullptr)
	{
		changeInTree(tree, position->left);
	}
	if (position->right != nullptr)
	{
		changeInTree(tree, position->right);
	}
}

void operation(Tree *tree, Position position)
{
	if (position->value == '+')
	{
		position->valueOfInt = (position->left->valueOfInt) + (position->right->valueOfInt);
	}

	if (position->value == '-')
	{
		position->valueOfInt = (position->left->valueOfInt) - (position->right->valueOfInt);
	}

	if (position->value == '*')
	{
		position->valueOfInt = (position->left->valueOfInt) * (position->right->valueOfInt);
	}

	if (position->value == '/')
	{
		position->valueOfInt = (position->left->valueOfInt) / (position->right->valueOfInt);
	}
}

int count(Tree *tree, Position position, Position preposition)
{
	if (position->value <= '9' && position->value >= '0')
	{
		return position->value;
	}

	if (position->left != nullptr)
	{
		count(tree, position->left, position);
	}

	if (position->right != nullptr)
	{
		count(tree, position->right, position);
	}	
	operation(tree, position);
	return position->valueOfInt;
}	


