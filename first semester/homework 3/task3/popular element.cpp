//Найти наиболее часто встречающийся элемент в массиве быстрее, чем за O(n^2).
#include <stdlib.h>
#include <iostream>

using namespace std;

void printArray(int a[], int size)
{
	for (int i = 0; i < size; ++i) {
		printf("%d ",a[i]);
	}
}

void qSort(int massiv[], int left, int right)
{
	if (left < right) {
		int orientation = massiv[left];
		int i = left;
		int j = right;
		while(i < j) {
			while(massiv[i] <= orientation && i < right) {
				++i;
			}
			while(massiv[j] >= orientation  && j > left) {
				--j;
			}
			 if (i < j) {
				 int obmen = massiv[i];
				 massiv[i] = massiv[j];
				 massiv[j] = obmen;
			 }
		}
 		 int obmen = massiv[left];
		 massiv[left] = massiv[j];
		 massiv[j] = obmen;

		qSort (massiv, left, j - 1);
		qSort (massiv, j + 1, right);
	}
}

int main ()
{
	int *massiv = new int[1000];
	srand(44);
	int arraysize = 0;
	printf("Input count of massve's elements ");
	cin >> arraysize;
	printf("Random massiv\n");
	for (int i = 0; i < arraysize; ++i) {
		massiv[i] = rand() % 10;
		printf("%d ", massiv[i]);
	}
	qSort(massiv, 0, arraysize - 1);
	printf("\n\n");
	printf("QSort massiv\n");
	printArray(massiv, arraysize);
	int i = 0;
	int max1 = massiv[0];
	int max2 = massiv[0];
	int countMax1 = 0;
	int countMax2 = 0;
	while (i < arraysize) {
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
		printf("\n\nPopular element %d ", max1);
	} else {
		printf("\n\nPopular element %d ", max2);
	}
	delete [] massiv;
}