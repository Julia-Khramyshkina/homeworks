#include <stdlib.h>
#include <iostream>

using namespace std;

void printArray(int a[], int size)
{
	for (int i = 0; i < size; ++i) {
		printf("%d ", a[i]);
	}
}
void sortOfInsert (int massiv[], int left, int right)
{
	for (int i = left + 1; i <= right; ++i)
	{
		for (int j = i; (j > left) && (massiv[j] < massiv[j - 1]); --j) 
		{
			int obmen = massiv[j];
			massiv[j] = massiv[j - 1];
			massiv[j - 1] = obmen;
		}
	}
}
void qSortWithInsert(int massiv[], int left, int right)
{
	if ((right - left + 1) >= 10) {
		int orientation = massiv[left];
		int i = left;
		int j = right;
		while(i < j) {
			while(massiv[i] < orientation && i < right) {
				++i;
			}
			while(massiv[j] >= orientation && j > left) {
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
		qSortWithInsert(massiv, left, j);
		qSortWithInsert(massiv, i, right);
	} else {
		sortOfInsert(massiv, left, right);
	}
}
int main ()
{
	srand(239);
	int *massiv = new int[100];
	int const arraysize = 88;
	printf("Massiv Random \n\n");
	for (int i = 0; i < arraysize; ++i) {
		massiv[i] = rand() % 200 - 10;
		printf("%d ", massiv[i]);
	}
	if (arraysize >= 10) {
		qSortWithInsert(massiv, 0, arraysize - 1);
	} else {
		sortOfInsert(massiv, 0, arraysize - 1);
	}
	printf("\n\nQSortWithInsert Massiv\n\n");
	printArray(massiv, arraysize);
	printf("\n");
	delete [] massiv;
	return 0;
}