
#include <iostream>
using namespace std;

bool is_prime(int num)
{
	if (num == 0 || num == 1)
		return false;

	if (num == 2)
		return true;

	if (num % 2 == 0)
		return false;

	for (register int i = 3; i < num / 2; i = i + 2)
		if (num % i == 0)
			return false;

	return true;
}
int main()
{
	int start, end;
	cout << "give me 2 number for start and end of range: ";
	cin >> start >> end;
	for (register int i = start; i < end; i++)
	{
		if (is_prime(i) == true)
		{
			cout << i << ", ";
		}
	}
}
