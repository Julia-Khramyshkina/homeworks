//Посчитать число "счастливых билетов" (билет считается "счастливым", если сумма первых трёх цифр его номера равна сумме трёх последних).//
#include <stdio.h>

int main()
{
	int const arraySize = 28;
	int massiv[arraySize] = {0};	

	for (int i = 0; i < 10; ++i) {
		for (int j = 0; j < 10; ++j) {
			for (int k = 0; k < 10; ++k){
				++massiv[k + i + j];
			}
		}
	}

	int sumOfHappyTickets = 0;
	for (int i = 0; i < arraySize; ++i) {
		sumOfHappyTickets += massiv[i] * massiv[i];
	}

	printf("Sum Of Happy Tickets = %d\n", sumOfHappyTickets);		
	return 0;
}