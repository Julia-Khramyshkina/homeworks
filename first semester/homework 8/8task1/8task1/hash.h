#pragma once
#include "list.h"

using namespace list;

namespace hash
{
// ���������� ���-�������
struct HashTable;

// �������� ���-�������
HashTable *createHashTable();

// �������� ���-�������
void deleteHashTable(HashTable *hashTable);

// ������� � ���-�������
void insertToHashTable(HashTable *hashTable, ElementType newElement);

// �������� ������������� ��������
bool exist(HashTable *hashTable, ElementType element);

// �������� ��������
void remove(HashTable *hashTable, ElementType element);

// ���������� ����
void printWords(HashTable *hashTable);
}