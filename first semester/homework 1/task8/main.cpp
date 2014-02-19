#include <stdio.h>
#include <string.h>
//Заданы две строки: S и S1. Найти количество вхождений S1 в S как подстроки.

int main()
{
	char *s = "abcd";
	char *s1 = "cdef";
	int kolichestvo = 0;

	for (int i = 0; s[i] != '\0'; ++i) {
		for (int j = 0; s1[j] != '\0'; ++j) {
			if (s[i + j] != s1[j]) {
				break;
			}
			if (j + i >= strlen(s)) {
				break;				
			}
			if (j == strlen(s1) - 1) {
				++kolichestvo;
			}
		}
	}
	printf("Kolichestvo vhogdeniy stroki S1 v S = %d\n", kolichestvo);	
}