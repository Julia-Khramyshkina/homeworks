#include <iostream>

using namespace std;

bool digit(char countSymbol)
{
	return (countSymbol <= '9' && countSymbol >= '0');
}

int main()
{
	enum state {begin, zero, one, win, fail};
	char countSymbol = ' ';
	state countState = begin;
	while (true) 
	{
		switch (countState)
		{
			case begin:
			{
				cin >> countSymbol;
				if (digit(countSymbol))
				{
					countState = one;
					break;
				}
				else
				{			
					countState = fail;
					break;
				}		
			}
			case zero:
			{
				cin >> countSymbol;
				if (digit(countSymbol))
				{
					countState = one;
					break;
				}
				else
				{			
					countState = fail;
					break;
				}		
			}
			case one:
			{
				cin >> countSymbol;
				if (digit(countSymbol))
				{
					countState = one;
					break;
				}
				else if (countSymbol == '.')
				{
					countState = zero;
					break;
				}
				else if (countSymbol == 'E')
				{
					cin >> countSymbol;
					if (countSymbol == '+' || countSymbol == '-')
					{
						countState = zero;
						break;
					}
					else if (digit(countSymbol))
					{
						countState = one;
						break;
					}
					else 
					{
						countState = fail;
						break;
					}
				}
				else if (countSymbol == '!')
				{
					countState = win;
					break;
				}
			}
			case win:
			{
				cout << "Yes, It is real number\n";
				return 0;
			}
			case fail:
			{
				cout << "No, It is not real number\n";
				return 0;
			}
		}
	}
}