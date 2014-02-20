#include <iostream>
#include "tree.h"
#include <fstream>

using namespace std;

int main()
{
	Tree *tree = create();
	fstream input("input.txt");
	char stringOfFile[255];
	input.getline(stringOfFile, 255);
	int i = 0;
	insertElement(tree, stringOfFile, i, first(tree));
	changeInTree(tree, first(tree));

	int answer = count(tree, first(tree), first(tree));
	cout << "Expression:" << endl;
	printArithmeticExpression(tree);
	cout << "\nAnswer " << answer << endl;
	remove(tree);
	return 0;
}