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

int main ()
{
	int *massiv = new int[1000];
	srand(239);
	int arraysize = 0;
	printf("Input count of massve's elements ");
	cin >> arraysize;
	printf("Random massiv\n");
	for (int i = 0; i < arraysize; ++i) {
		massiv[i] = rand() % 200 - 10;
		printf("%d ", massiv[i]);
	}