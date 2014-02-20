#include "qSort.h"
void qSort(int massiv[], int left, int right)
{
	if (left < right) {
		int orientation = massiv[left];
		int i = left;
		int j = right;
		while(i < j) {
			while(massiv[i] <= orientation && i < right) {
				++i;
			}
			while(massiv[j] >= orientation  && j > left) {
				--j;
			}
			if (i < j) {
				int obmen = massiv[i];
				massiv[i] = massiv[j];
				massiv[j] = obmen;
			}
		}
 		int obmen = massiv[left];
		massiv[left] = massiv[j];
		massiv[j] = obmen;

		qSort (massiv, left, j - 1);
		qSort (massiv, j + 1, right);
	}
}