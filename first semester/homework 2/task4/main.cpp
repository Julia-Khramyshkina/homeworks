#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <time.h>

void printArray(int s[], int size)
{
	for (int i = 0; i < size; ++i)
		printf("%d ", s[i]);
}

int main()

{
	srand(time(NULL));

	int *mas = new int[100];
	int n = 0;

	printf("Input count of massve's elements: ");
	scanf_s("%d", &n);

	printf("Massive of random elements:  ");
	for (int i = 0; i < n; ++i)
	{
		mas[i] = rand() % 10;
		printf("%d ", mas[i]);
	}

	int k = mas[0];

	printf("\n");

	int l = 0;
	int r = n - 1;
	while (l < r)
	{

		while (mas[l] < k)
		{
			++l;
		}
		while (mas[r] > k)
		{
			--r;
		}
		int t = mas[l];
		mas[l] = mas[r];
		mas[r] = t;
	}
	printf("The sorted elements: ");
	printArray(mas, n);
	delete[] mas;
	printf("\n");
	return 0;
}