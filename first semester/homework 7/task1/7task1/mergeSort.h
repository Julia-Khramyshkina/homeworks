#pragma once

#include "list.h"
#include "listMas.h"
#include "String.h"


using namespace list;


Position middle(List *list, Position left, Position right);
bool regulation(ElementType direction1, ElementType direction2, bool criterion);
List *merge(List *list1, List *list2, bool criterion);
List *mergeSort(List *list, bool criterion);

