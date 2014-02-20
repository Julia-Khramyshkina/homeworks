#include <stdlib.h>
#include "list.h"
#include <iostream>

using namespace std;

int main()
{
	List *list = create();
	cout << "Please input the number of soldiers \n";
	int theNumberOfSoldiers = 0;
	cin >> theNumberOfSoldiers;
	
	cout << "Please input the number of death \n";
	int theNumberOfDeath = 0;
	cin >> theNumberOfDeath;
	
	for (int anotherSoldier = 1; anotherSoldier <= theNumberOfSoldiers; ++anotherSoldier)
		insert(list, anotherSoldier);

	findTheThatGuysWhoMustDie(list, theNumberOfDeath, theNumberOfSoldiers);

	cout << "The surviving soldier" << endl;
	printAnswer(list);
	delete list;
}