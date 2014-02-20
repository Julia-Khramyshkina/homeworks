#include <iostream>
#include <fstream>

using namespace std;

int hashFunctionForRabinCarp(char* sample, int sizeofSample)
{
	int tempValue = 1;
	int result = sample[sizeofSample - 1]; 
	for (int i = sizeofSample - 2; i >= 0; --i)
	{	
		tempValue = tempValue * 13;
		result = result + sample[i] * tempValue;		
	}
	return result;
}

int reHash(int oldValueOfFunction, char predSymbol, char newSymbol, int size)
{
	return (oldValueOfFunction  - pow(13, size - 1) * predSymbol) * 13 + newSymbol; 
}

char* partOfstring(char* countString, int begin, int size)
{
	char tempString[255];
	for (int i = 0; i < size; ++i)
	{
		tempString[i] = countString[begin];
		++begin;
	}
	tempString[size] = '\0';
	return tempString;
}

int lengthOfWord(char* word)
{
	int size = 0;
	while (word[size] != '\0')
	{
		++size;
	}
	return size;
}

int main()
{
	fstream input("input.txt");
	char sample[255];
	char countSymbol = ' ';
	cin >> sample;

	int size = lengthOfWord(sample);
	int valueHashFunctionOfSample = hashFunctionForRabinCarp(sample, size);

	int numberOfString = 0;
	countSymbol = ' ';
	while (!input.eof())
	{
		char newString[255];
		input.getline(newString, 255);
		int i = 0;
		int countValueOfHash = 0;
		char tempString[255];
		strcpy(tempString, partOfstring(newString, 0, size));
		countValueOfHash = hashFunctionForRabinCarp(tempString, size);
		while (newString[i] != '\0')
		{
			if (countValueOfHash != valueHashFunctionOfSample)
			{
				++i;
				countValueOfHash = reHash(countValueOfHash, newString[i - 1], newString[i + size - 1], size);
			}
			else
			{
				strcpy(tempString, partOfstring(newString, i, size));
				if (strcmp(tempString, sample) == 0)
				{
					cout << numberOfString + 1 << ' ' << i + 1 << endl;
					input.close();
					return 0;
				}
				else
				{
					i = i + size;
				}
			}
		}
		++numberOfString;
	}
	cout << "Not found" << endl;
	return 0;
}