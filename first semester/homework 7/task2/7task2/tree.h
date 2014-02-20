#pragma once

typedef int Element;

// объ€вление дерева
struct Tree;

// создание дерева
Tree *create();

// удаление дерева
void remove(Tree *tree);

// вставка элемента в дерево
void insertElement(Tree *tree, Element value);

// удаление элемента из дерева
void removeElement(Tree *tree, Element value);

// проверка существовани€ элемента
bool exists(Tree *tree, Element value);

// вывод эдементов дерева по возрастанию
void printAscending(Tree *tree);

// вывод эдементов дерева по убыванию
void printDescending(Tree *tree);

// проверка дерева на пустоту
bool emptyTree(Tree *tree);
