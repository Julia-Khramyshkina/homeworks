#pragma once

typedef char Element;

// объ€вление дерева
struct Tree;
struct ElementOfTree;
typedef ElementOfTree *Position;
// создание дерева
Tree *create();

// удаление дерева
void remove(Tree *tree);

// вставка элемента в дерево
void insertElement(Tree *tree, char* stringOfFile, int &i, Position position);

// удаление элемента из дерева
void removeElement(Tree *tree, Element value);

// проверка существовани€ элемента
bool exists(Tree *tree, Element value);

// вывод арифметического выражени€
void printArithmeticExpression(Tree *tree);

// проверка дерева на пустоту
bool emptyTree(Tree *tree);

// замена символьных значений на числовые там, где это необходимо
void changeInTree(Tree *tree, Position position);

// подсчет значени€ выражени€
int count(Tree *tree, Position position, Position preposition);

// первый элемент дерева
Position first(Tree *tree);
