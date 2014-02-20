//Написать сортировки пузырьком и подсчётом
#include <iostream>

using namespace std;

int main()
{
	int massivOld[1000] = {0};
	int massivNew[1000] = {0};
	int numberOfElements = 0;
	cout << "Please, vvedite chislo elementov v massiv'e i sami elementy" << endl;
	cin >> numberOfElements;
	int maxElement = 0;
	for (int i = 0; i < numberOfElements; ++i) {
		int n = 0;
		cin >> n;
		++massivOld[n];
		if (n > maxElement)	{
			maxElement = n;
		}
	}
	int j = 0;
	printf("Otsortirg1ovannyy massiv\n");
	for (int i = 0; i <= maxElement; ++i) {
		while (massivOld[i] > 0) {
			massivNew[j] = i;
			++j;
			--massivOld[i];
			printf("%d ", massivNew[j - 1]);
		}
	}
	return 0;
}