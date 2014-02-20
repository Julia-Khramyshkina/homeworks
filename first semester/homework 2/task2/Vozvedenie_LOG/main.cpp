//Реализовать возведение в степень - в лоб и придумать, как быстрее, за О(log n)
#include <iostream>

using namespace std;

int numberToDegree(int number, int degree) {
	if (degree == 1) {
		return number;			
	} else if ((degree % 2) == 0) {
		int newNumber = numberToDegree(number, degree / 2);
		return newNumber * newNumber;
	} else {
		int newNumber = numberToDegree(number, degree - 1);
		return newNumber * number;
	}
}

int main()
{
	cout << "Please input number" << endl;
	int number = 0;
	cin >> number;
	cout << "Please input degree of number" << endl;
	int degree = 0;
	cin >> degree;
	if (degree == 0) {
		printf("Result %d\n", 1);
		return 0;
	}
	if (degree == 1) {
		printf("Result %d\n", number);
		return 0;
	}
	printf("Result %d\n", numberToDegree(number, degree));
	return 0;
}