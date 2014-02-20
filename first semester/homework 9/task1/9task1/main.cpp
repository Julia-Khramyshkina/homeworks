#include <iostream>
#include <fstream>
using namespace std;


bool addNewCity(int **matrix, bool *used, int *massivOfCities, int capital, int amountOfCities)
{
	
	int minWay = 1000000;
	int topForRememberJ = -1;
	for (int i = 0; i < amountOfCities; ++i)
	{	
		if (massivOfCities[i] == capital)
		{
			for (int j = 0; j < amountOfCities; ++j)
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
		massivOfCities[topForRememberJ] = capital;
		return true;
	}
	return false;
}

int main()
 {
	fstream input("input.txt");
	int amountOfCities = 0;
	int amountOfWays = 0;
	input >> amountOfCities;
	input >> amountOfWays;
	int **matrix = new int*[amountOfCities];

	for (int i = 0; i < amountOfCities; ++i)
	{
		matrix[i] = new int[amountOfCities];
	}

	for (int i = 0; i < amountOfCities; ++i)
	{
		for (int j = 0; j < amountOfCities; ++j)
		{
			matrix[i][j] = 0;
		}
	}

	while (amountOfWays != 0)
	{
		int i = 0;
		input >> i;
		int j = 0;
		input >> j;
		int len = 0;
		input >> len;
		matrix[i - 1][j - 1] = len;
		--amountOfWays;
	}
	int amountOfCapitals = 0;
	input >> amountOfCapitals;
	int *massivColors = new int[amountOfCapitals];
	int *massivOfCities = new int[amountOfCities];

	for (int i = 0; i < amountOfCities; ++i)
	{
		massivOfCities[i] = i;
	}

	bool *used = new bool[amountOfCities];

	for (int i = 0; i < amountOfCities; ++i)
	{
		used[i] = false;
	}

	for (int i = 0; i < amountOfCapitals; ++i)
	{
		int temp = 0;
		input >> temp;
		massivColors[i] = temp - 1;
		used[temp - 1] = true;
	}
	int amountOfFreeTops = amountOfCities - amountOfCapitals;
	while (amountOfFreeTops > 0)
	{
		for (int i = 0; i < amountOfCapitals; ++i)
		{
			if (addNewCity(matrix, used, massivOfCities, massivColors[i], amountOfCities))
			{
				--amountOfFreeTops;
			}
		}
	}

	for (int i = 0; i < amountOfCapitals; ++i)
	{
		cout << "Capital is " << massivColors[i] + 1 << ' ';
		cout << "All cities of this country" << ' ';
		for (int j = 0; j < amountOfCities; ++j)
		{
			if (massivOfCities[j] == massivColors[i])
			{
				cout << j + 1 << ' ';
			}
		}
		cout << '\n';
	}

	for (int i = 0; i < amountOfCities; ++i)
	{
		delete matrix[i];
	}

	delete [] matrix;
	delete [] massivColors;
	delete [] massivOfCities;
	delete [] used;
	return 0;
}


