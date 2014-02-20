#include <iostream>
#include <fstream>

using namespace std;

int valueOfCountSymbol(char countSymbol)
{
	if (countSymbol == '/')
	{
		return 0;
	}
	if (countSymbol == '*')
	{
		return 1;
	}
	return 2;
}

int main()
{
	fstream table("table.txt");
	int amountStrings = 0;
	table >> amountStrings;
	int amountOfColumn = 0;
	table >> amountOfColumn;

	int **matrix = new int*[amountStrings];
	for (int i = 0; i < amountStrings; ++i)
	{
		matrix[i] = new int[amountStrings];
	}

	for (int i = 0; i < amountStrings; ++i)
	{
		for (int j = 0; j < amountOfColumn; ++j)
		{
			int countElement = 0;
			table >> countElement;

			matrix[i][j] = countElement;
		}
	}
	table.close();

	fstream input("input.txt");
	char countSymbol = ' ';	
	int state = 0;
	bool alreadyStarted = false;

	while (!input.eof())
	{
		countSymbol = input.get();
		int value = valueOfCountSymbol(countSymbol);
		state = matrix[state][value];
		if (state == 2 && !alreadyStarted)
		{
			alreadyStarted = true;
			cout << "/" << countSymbol;
		}

		else if (state == 2 || state == 3)
		{
			cout << countSymbol;
		}

		if (state == 4)
		{
			cout << countSymbol << endl;
			state = 0;
			alreadyStarted = false;
		}
	}

	for (int i = 0; i < amountStrings; ++i)
	{
		delete matrix[i];
	}
	delete [] matrix;
	return 0;
}
