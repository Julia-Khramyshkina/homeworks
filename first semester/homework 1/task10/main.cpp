#include <stdio.h>
#include <cmath>
#include <time.h>
 //   Написать программу, считающую количество нулевых элементов в массиве.


int main()
{
	int const arraySize = 5;
	int a[arraySize] = {0};
	printf("Input array of elements \n");
	int countZeroElements = 0;
	for (int i = 0; i < arraySize; ++i) {
		scanf("%d", &a[i]);
	}
	for (int i = 0; i < arraySize; ++i) {
		if (a[i] == 0) {
			++countZeroElements;
		}
	}
	printf("Count of zero elements = %d\n", countZeroElements);
}