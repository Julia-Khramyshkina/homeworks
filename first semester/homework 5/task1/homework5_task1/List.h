#pragma once

// создание синонимичных типов
typedef int NumberType;
typedef char* NameType;
typedef int Position;

// создание структуры списка
struct List;

// функция для создания самого списка 
List *create();

// функция вставки очередной записи в список
void insert(List *list, NameType who, NumberType phone);

// проверка существования номера с заданным именем
bool badmeanWithoutNumber(List *list, NameType who);

// получение номера по имени
NumberType getNumber(List *list,  NameType who);

// проверка существования имени с заданным номером
bool badMeanWithoutName(List *list, NumberType phone);

// получение имени по номеру
NameType getName(List *list, NumberType phone);

// удаление списка
void deleteList(List *list);