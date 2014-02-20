#include "tree.h"
#include <iostream>

using namespace std;

struct ElementOfTree
{
	Element value;	
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

void insertElement(Tree *tree, Element value)
{
	if (exists(tree, value))
	{
		return;
	}

	ElementOfTree *temp = new ElementOfTree;
	temp->value = value;
	temp->left = nullptr;
	temp->right = nullptr;

	if (tree->head == nullptr)
	{
		tree->head = temp;
		return;
	}

	ElementOfTree *counter = tree->head;
	while (counter->left != nullptr || counter->right != nullptr)
	{
		if (value > counter->value)
		{
			if (counter->right == nullptr)
			{
				break;
			}
			counter = counter->right;
		}
		else
		{
			if (counter->left == nullptr)
			{
				break;
			}
			counter = counter->left;
		}
	}
	if (counter->value > value)
	{
		counter->left = temp;
	}
	else
	{
		counter->right = temp;
	}
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
				previousCounter = previousCounter->left;
			}
		}
	}

	if (counter == previousCounter)
	{
		ElementOfTree *searchCounter = counter;
		if (counter->right != nullptr)
		{

			searchCounter = counter->right;
		
			while (searchCounter->left != nullptr)
			{
				searchCounter = searchCounter->left;
			}
		}

		else if (counter->left != nullptr)
		{

			searchCounter = counter->left;
		
			while (searchCounter->right != nullptr)
			{
				searchCounter = searchCounter->right;
			}
		}

		if (counter->left == nullptr && counter->right == nullptr)
		{
			removeSubTree(tree->head);
			tree->head = nullptr;
			return;
		}

		Element temp = searchCounter->value;
		removeElement(tree, searchCounter->value);
		counter->value = temp;
		return;
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

void printAscendingDouble(ElementOfTree *currentElement)
{
	if (currentElement != nullptr)
	{
		printAscendingDouble(currentElement->left);
	}

	cout << currentElement->value << endl;

	if (currentElement != nullptr)
	{
		printAscendingDouble(currentElement->right);
	}
}

void printAscending(Tree *tree)
{
	printAscendingDouble(tree->head);
}

void printDescendingDouble(ElementOfTree *currentElement)
{
	if (currentElement->right != nullptr)
	{
		printDescendingDouble(currentElement->right);		
	}

	cout << currentElement->value << endl;

	if (currentElement->left != nullptr)
	{
		printDescendingDouble(currentElement->left);
	}
}

void printDescending(Tree *tree)
{
	printDescendingDouble(tree->head);
}

bool emptyTree(Tree *tree)
{
	return (tree->head == nullptr);
}