#include "hash.h"
#include "list.h"

using namespace list;
const int hashTableSize = 500;

struct hash::HashTable
{
	List *bucket[hashTableSize];
};

hash::HashTable *hash::createHashTable()
{
	hash::HashTable *hashTable = new hash::HashTable;
	for (int i = 0; i < hashTableSize; ++i)
	{
		hashTable->bucket[i] = create();	
	}
	return hashTable;
}

void hash::deleteHashTable(HashTable *hashTable)
{
	for (int i = 0; i < hashTableSize; ++i)
	{
		deleteList(hashTable->bucket[i]);
	}
	delete hashTable;
}

int hashFunction(ElementType newElement)
{	
	int valueOfHashFunction = 0;
	for (int i = 0; i < newElement.length; ++i)
	{
		valueOfHashFunction = valueOfHashFunction + newElement.newWord[i] * i;
	}
	valueOfHashFunction = (valueOfHashFunction * ((newElement.length * newElement.length) + (newElement.length / 3) - 1)) % hashTableSize;
	return valueOfHashFunction;
}

void hash::insertToHashTable(HashTable *hashTable, ElementType newElement)
{
	if (exist(hashTable->bucket[hashFunction(newElement)], newElement))
	{
		increase(hashTable->bucket[hashFunction(newElement)], newElement);
	}
	else
	{
		insertToEnd(hashTable->bucket[hashFunction(newElement)], newElement);
	}
}

bool hash::exist(HashTable *hashTable, ElementType element)
{
	return exist(hashTable->bucket[hashFunction(element)], element);
}

void hash::remove(HashTable *hashTable, ElementType element)
{
	remove(hashTable->bucket[hashFunction(element)], positionOfElement(hashTable->bucket[hashFunction(element)], element));
}

void hash::printWords(HashTable *hashTable)
{
	for (int i = 0; i < hashTableSize; ++i)
	{
		printWords(hashTable->bucket[i]);
	}
}