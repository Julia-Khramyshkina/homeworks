#pragma once
#include "list.h"

using namespace list;

namespace hash
{
// объявление хэш-таблицы
struct HashTable;

// создание хэш-таблицы
HashTable *createHashTable();

// удаление хэш-таблицы
void deleteHashTable(HashTable *hashTable);

// вставка в хэш-таблицу
void insertToHashTable(HashTable *hashTable, ElementType newElement);

// проверка существования элемента
bool exist(HashTable *hashTable, ElementType element);

// удаление элемента
void remove(HashTable *hashTable, ElementType element);

// распечатка слов
void printWords(HashTable *hashTable);
}