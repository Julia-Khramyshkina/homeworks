#include <iostream>
#include "tree.h"

using namespace std;

enum input {out = 0, add, deleteElement, exist, printAscendingTree, printDescendingTree};

input valueOfCountInput(int countSymbol)
{
	if (countSymbol == 0)
		return out;
	if (countSymbol == 1) 
		return add;
	if (countSymbol == 2)
		return deleteElement;
	if (countSymbol == 3)
		return exist;
	if (countSymbol == 4)
		return printAscendingTree;
	if (countSymbol == 5)
		return printDescendingTree;
}

int main()
{
	Tree *tree = create();
	cout << "Hello! Please input the command \n";
	cout << "0 - exit\n";
	cout << "1 - add element \n";
	cout << "2 - delete element \n";
	cout << "3 - check exist element \n";
	cout << "4 - print elements in ascending order \n";
	cout << "5 - print elements in descending order \n";

	while (true)
	{
		cout << "Please input the command \n";
		int countSymbol = 0;
		cin >> countSymbol;
		input countInput = valueOfCountInput(countSymbol);
		switch (countInput)
		{
			case out:
			{
				return 0;
				break;
			}
			case add:
			{
				cout << "please, input element \n";
				int newElement = 0;
				cin >> newElement;
				insertElement(tree, newElement);
				break;
			}
			case deleteElement:
			{
				int newElement = 0;
				cout << "please, input element \n";
				cin >> newElement;
				if (!exists(tree, newElement))
				{
					cout << "sorry, element doesn't exist\n";
				}
				else
				{
					removeElement(tree, newElement);
				}		
				break;
			}
			case exist:
			{
				cout << "please, input element \n";
				int newElement = 0;
				cin >> newElement;
				if (exists(tree, newElement))
				{
					cout << "element exist\n";
				}
				else
				{
					cout << "sorry, element doesn't exist\n";
				}
				break;
			}
			case printAscendingTree:
			{	
				if (emptyTree(tree))
				{
					cout << "sorry, elements don't exist\n";
				}
				else
				{
					cout << "elements in ascending order \n";
					printAscending(tree);
				}
				break;
			}		
			case printDescendingTree:
			{
				if (emptyTree(tree))
				{
					cout << "sorry, elements don't exist\n";
				}
				else
				{
					cout << "elements in descending order \n";
					printDescending(tree);
				}
				break;
			}
		}
	}
}

