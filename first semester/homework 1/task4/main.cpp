#include <stdio.h>
#include <cmath>
//Написать программу нахождения неполного частного от деления a на b (целые числа), 
//используя только операции сложения, вычитания и умножения.

int main()
{
	int delimoe = 0;
	int delitel = 0;
	printf("Input delimoe and delitel\n");
	scanf("%d", &delimoe);
	scanf("%d", &delitel);
	if (delitel == 0) {
		printf("Delenie na 0, sorry\n");
		return 0;
	}
	bool chislaOdnogoZnaka = false;
	if (delimoe * delitel > 0) {
		chislaOdnogoZnaka = true;
	}
	
	int chastnoe = 0;
	delimoe = abs(delimoe);
	delitel = abs(delitel);
	while (delimoe >= delitel) {
		delimoe = delimoe - delitel;
		++chastnoe;
	}

	if (chislaOdnogoZnaka) {
		printf("Nepolnoe chastnoe = %d\n", chastnoe);
	}
	else {
		printf("Nepolnoe chastnoe = %d\n", -chastnoe);
	}
	return 0;
}