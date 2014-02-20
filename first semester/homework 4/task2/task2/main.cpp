#include <stdio.h>
#include <stdlib.h>
#include "qSort.h"
#include "printArray.h"
#include <iostream>
#include <fstream>

using namespace std;

int main ()
{
	int *massiv = new int[1000];
	int arraySize = 0;
	fstream is("text.txt");
	is >> arraySize;
	printf("Random massiv\n");
	for (int i = 0; i < arraySize; ++i) {		
		is >> massiv[i];
		cout << massiv[i] << " ";
	}
	is.close();
	qSort(massiv, 0, arraySize - 1);
	int i = 0;
	int max1 = massiv[0];
	int max2 = massiv[0];
	int countMax1 = 0;
	int countMax2 = 0;
	while (i < arraySize) {
		if (massiv[i] != max1) {
			if (countMax1 > countMax2) {
				countMax2 = countMax1;
				max2 = max1;
				countMax1 = 1;
			}
			max1 = massiv[i];
			countMax1 = 1;
			++i;
		} else {
			++countMax1;
			++i;
		}
	}
	if (countMax1 >= countMax2) {
		printf("\n\nPopular element %d \n", max1);
	} else {
		printf("\n\nPopular element %d \n", max2);
	}
	delete [] massiv;
	return 0;
}