//Реализовать возведение в степень - в лоб и придумать, как быстрее, за О(log n)
#include <iostream>
using namespace std;
int main()
{
	cout << "Please input chislo" << endl;
	int chislo = 0;
	cin >> chislo;
	cout << "Please input stepen chisla" << endl;
	int stepen = 0;
	cin >> stepen;
	if (stepen == 0) {
		printf ("Result %d\n", 1);
		return 0;
	}
	int result = 1;
	for (int i = 1; i <= stepen; ++i) {
		result *= chislo;
	}
	printf ("Result %d\n", result);
}

