#include <stdio.h>
//�������� ���������, ��������� �������� ������� x^4 + x^3 + x^2 + x �� ��� ���������.

int main()
{ 
	int x = 0;
	printf("Input mean of x \n");
	scanf("%d", &x);
	int x2 = x * x;
	int y = (x2 + 1) * (x2 + x);
	printf("Answer = %d \n", y);
}