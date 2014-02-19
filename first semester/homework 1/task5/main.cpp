#include <stdio.h>
#include <cmath>
#include <time.h>
#include <stdlib.h>
/* Дан массив целых чисел x[1]...x[m+n], рассматриваемый как соединение двух его отрезков: 
начала x[1]...x[m] длины m и конца x[m+1]...x[m+n] длины n. Не используя дополнительных массивов, переставить начало и конец.*/
void vvodOfMas(int a[], int size)
{
	for (int i = 0; i < size; ++i) {
		scanf("%d", &a[i]);
	}
}

void perestanovka(int left, int right, int mas[])
{
	int centr = (right - left) / 2;

	for (int i = 0; i <= centr; ++i) {		
		int dop = mas[left + i];
		mas[left + i] = mas[right - i];
		mas[right - i] = dop;
	}
}

void printArray(int a[], int size)
{
	for (int i = 0; i < size; ++i) {
		printf("%d ", a[i]);
	}
}

int main()
{
	int const arraySize = 7;
	int massiv[arraySize] = {0};	
	printf("Input elements of array\n");
	vvodOfMas(massiv,arraySize);
	int left = 0;
	int right = 0;
	printf("Input dliny otrezkov\n");
	scanf("%d", &left);
	scanf("%d", &right);

	perestanovka(0, left - 1, massiv); 
	perestanovka(left, left + right - 1, massiv); 
	perestanovka(0, left + right - 1, massiv); 

	printArray (massiv, arraySize);
	return 0;
}