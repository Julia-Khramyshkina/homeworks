#pragma once


namespace list
{

// объявление структуры для хранения слова и его длины
struct Word
{
	char* newWord;
	int length;
};

typedef Word ElementType;

// появление списка
struct List;
struct ListElement;
typedef ListElement *Position;

// явное предъявление списка
List *create();

// операция вставки в конец списка
void insertToEnd(List *list, ElementType value);

// распечатка списка
void print(List *list);

Position first(List *list);
Position end(List *list);
Position next(List *list, Position position);
Position previous(List *list, Position position);

// размер списка
int sizeOfList (List *list);

// выдача значения по позиции
ElementType valueOnPosition(List *list, Position Position);

// очистка совести ^W памяти
void deleteList(List *list);

// вставка элемента в начало спискка
void insertToHead(List *list, ElementType value);

// удаление элемента по текущей позиции
void remove(List *list, Position position);

// проверка существования элемента
bool exist(List *list, ElementType value);

// получение позиции элемента по его значению
Position positionOfElement(List *list, ElementType value);

// распечатка слов
void printWords(List *list);

// проверка списка на пустоту
bool empty (List *list);

// увеличение значения одного из полей элемента
void increase(List *list, ElementType value);
}