//Написать сортировки пузырьком и подсчётом
#include <iostream>
using namespace std;
void printArray( int a[], int size)
{
	for (int i = 0; i <size; ++i) {
		printf("%d ", a[i]);
	}
}

int main()
{
	int *massiv = new int[100];
	int numberOfElements = 0;
	cout << "Please, vvedite chislo elementov v massiv'e i sami elementy" << endl;
	cin >> numberOfElements;
	for (int i = 0; i < numberOfElements; ++i) {
		cin >> massiv[i];	
	}
	for (int i = 0; i < (numberOfElements - 1); ++i) {
		for (int j = 0; j < (numberOfElements - 1); ++j) {
			if (massiv[j + 1] > massiv[j]) {
				int peremennyy = massiv[j+1];
				massiv[j + 1] = massiv[j];
				massiv[j] = peremennyy;
			}
		}
	}
	printf("Otsortirovannyy massiv \n");
	printArray(massiv, numberOfElements);
	delete[] massiv;
	return 0;
}
