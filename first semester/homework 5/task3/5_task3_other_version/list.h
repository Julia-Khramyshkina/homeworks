#pragma once

typedef int ElementType;

// создание циклического списка и его полей
struct List;
struct ListElement;

typedef ListElement *Position;

// явное предявление списка, который был создан
List *create();

void insert(List *list, ElementType value);

// поиск того, кто должен умереть
void findTheThatGuysWhoMustDie(List *list, ElementType theNumberOfDeath, ElementType theNumberOfSoldiers);

// определение позиции того, кто должен умереть, относительно начала и конца списка
void deleteElement(List *list, Position badPosition);

// собственно убийство
void deleteContinue(List *list, Position temp, Position counter);

// вывод ответа
void printAnswer(List *list);