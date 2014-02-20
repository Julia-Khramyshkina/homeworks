#include <iostream>
#include <fstream>

using namespace std;

void addNewTop(int **matrix, bool *used, int *massivOfTops, int amountOfTops, int lastBusyTop)
{
	int minWay = 1000000;
	int topForRememberJ = -1;
	for (int i = 0; i < amountOfTops; ++ i)
	{
		if (massivOfTops[i] != -1)
		{
			for (int j = 0; j < amountOfTops; ++j)
			{	
				if (matrix[i][j] != 0 && !used[j] && matrix[i][j] < minWay)
				{
					minWay = matrix[i][j];
					topForRememberJ = j;
				}		
			}
		}
	}
	if (topForRememberJ != -1)
	{
		used[topForRememberJ] = true;
		++lastBusyTop;
		massivOfTops[lastBusyTop] = topForRememberJ;		
	}
}

int main()
{
	fstream input("input.txt");
	int amountOfTops = 0;
	input >> amountOfTops;
	int **matrix = new int*[amountOfTops];

	for (int i = 0; i < amountOfTops; ++i)
	{
		matrix[i] = new int[amountOfTops];
	}

	for (int i = 0; i < amountOfTops; ++i)
	{
		for (int j = 0; j < amountOfTops; ++j)
		{
			int length = 0;
			input >> length;
			matrix[i][j] = length;
		}
	}
	
	bool *used = new bool[amountOfTops];
	used[0] = true;
	for (int i = 1; i < amountOfTops; ++i)
	{
		used[i] = false;
	}

	int *massivOfTops = new int[amountOfTops];
	massivOfTops[0] = 0;
	for (int i = 1; i < amountOfTops; ++i)
	{
		massivOfTops[i] = -1;
	}

	int tempAmountOfTops = amountOfTops;
	int lastBusyTop = 0;
	while (tempAmountOfTops > 0)
	{
		addNewTop(matrix, used, massivOfTops, amountOfTops, lastBusyTop); 
		--tempAmountOfTops;
		++lastBusyTop;
	}

	cout << "Minimum spanning tree" << endl;
	for (int i = 0; i < amountOfTops; ++i)
	{
		cout << massivOfTops[i] + 1 << ' ';
	}
	
	for (int i = 0; i < amountOfTops; ++i)
	{
		delete matrix[i];
	}
	cout << endl;

	delete matrix;
	delete used;
	delete massivOfTops;
	return 0;
}