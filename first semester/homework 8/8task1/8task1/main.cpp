#include "hash.h"
#include "list.h"
#include <iostream>
#include <fstream>

using namespace std;
using namespace list;
using namespace hash;

int main()
{
	HashTable *hashTable = createHashTable();

	fstream input("input.txt");
	char currentSymbol = ' ';

	if (input.is_open()) 
	{
		while (!input.eof()) 
		{
			ElementType currentWord;
			int counter = 0;
			currentWord.newWord = new char[20];
			currentWord.length = 0;
			while (currentSymbol != ' ' && currentSymbol != '\n' && currentSymbol != '\0' && !input.eof())
			{
				currentWord.newWord[counter] = currentSymbol;
				++currentWord.length;
				++counter;
				input.get(currentSymbol);
				
			}
			currentWord.newWord[counter] = '\0';
			++currentWord.length;
			if (currentWord.length > 1)
			{
				insertToHashTable(hashTable, currentWord);
			}
			while ((currentSymbol == ' ' || currentSymbol == '\n' || currentSymbol == '\0') && !input.eof())
			{
				input.get(currentSymbol);
			}
			
		}
	}
	input.close();
	cout << "Word's from file" << endl;
	printWords(hashTable);
	deleteHashTable(hashTable);
	return 0;
}