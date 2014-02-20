#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	ifstream is("text.txt");
	char symbol = ' ';
	int amountNotEmptyString = 0;
	bool stringWithSymbol = false;
	while (!is.eof()) 
	{
		is.get(symbol);
		stringWithSymbol = false;
		while ((symbol != '\n') && (symbol != '\0') && !is.eof()) 
		{
			if ((symbol != ' ') && (symbol != '\n') && (symbol != '\t') && (symbol != '\0'))
			{
				stringWithSymbol = true;
			}
			is.get(symbol);
		}
		if (stringWithSymbol) 
		{
			++amountNotEmptyString;
		}
	}
	is.close();
	printf("Amount of not-empty string in file %d \n", amountNotEmptyString);
	return 0;
}