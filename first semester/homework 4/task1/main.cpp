#include <stdlib.h>
#include <iostream>
#include <math.h>

using namespace std;

void transferToBinary (bool result[], int number)
{
	int mask = 1;
	for (int i = 0; i < sizeof(int) * 8; ++i) 
		{
			result[i] = (number & mask) != 0;
			mask = mask << 1;
		}
}

void countSum (bool result1[], bool result2[], bool resultOfSum[])
{
	bool flag = false;
	bool flag2 = true;
	int i = 0;
	while (i < sizeof(int) * 8) 
	{
		if (result1[i] && result2[i] && !flag && flag2)
		{
			resultOfSum[i] = false;
			flag = true;
			flag2 = false;
		}
		if (result1[i] && result2[i] && flag && flag2)
		{
			resultOfSum[i] = true;
			flag = true;
			flag2 = false;
		}
		if (!result1[i] && !result2[i] && !flag && flag2)
		{
			resultOfSum[i] = false;
			flag = false;
			flag2 = false;
		}
		if (!result1[i] && !result2[i] && flag && flag2)
		{
			resultOfSum[i] = true;
			flag = false;
			flag2 = false;
		}
		if ((result1[i] || result2[i]) && !flag && flag2)
		{
			resultOfSum[i] = true;
			flag = false;
			flag2 = false;
		}
		if ((result1[i] || result2[i]) && flag && flag2)
		{
			resultOfSum[i] = false;
			flag = true;
			flag2 = false;
		}
		++i;
		flag2 = true;
	}
}

int main()
{
	setlocale(LC_ALL, "rus");
	int number1 = 0;
	int number2 = 0;
	bool result1[sizeof(int) * 8];
	printf("Введите первое число ");
	cin >> number1;
	transferToBinary(result1, number1);
	printf("\nДвоичное представление первого числа\n"); 
	for (int i = sizeof(int) * 8 - 1; i >= 0 ; --i) 
	{
		printf("%d ", result1[i]);
	}
	printf("\n\nВведите второе число ");
	cin >> number2;
	bool result2[sizeof(int) * 8];
	transferToBinary(result2, number2);
	printf("\nДвоичное представление второго числа\n");
	for (int i = sizeof(int) * 8 - 1; i >= 0 ; --i) 
	{
		printf("%d ", result2[i]);
	}
	bool resultOfSum[sizeof(int) * 8];
	countSum(result1, result2, resultOfSum);
	printf("\n\nДвоичное представление суммы этих чисел\n"); 
	for (int i = sizeof(int) * 8 - 1; i >= 0 ; --i) 
	{
		printf("%d ", resultOfSum[i]);
	}
	number1 = 0;
	int sign = true;
	if (resultOfSum[sizeof(int) * 8 - 1]) 
	{
		number1 = 1;
		sign = false;
		for (int i = sizeof(int) * 8 - 1; i >= 0 ; --i) 
		{
			resultOfSum[i] = !resultOfSum[i];
		}
	}
	int actualPowerOfTwo = 1;
	for (int i = 0; i < sizeof(int) * 8; ++i) 
	{
		if (resultOfSum[i])
		{
			number1 = number1 + actualPowerOfTwo;
		}
		actualPowerOfTwo = actualPowerOfTwo * 2;
	}
	if (sign)
	{
		printf("\n\nДесятичное представление этой суммы %d \n", number1);
	}
	else
	{
		printf("\n\nДесятичное представление этой суммы %d \n", -number1);
	}
	return 0;
}