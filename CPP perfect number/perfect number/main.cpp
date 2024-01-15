#include <iostream>
using namespace std;
bool perfect_checker(int num)
{
    int sum = 0;
    for (int j = 1 ; j<num ; j++)
    {
        if (num % j == 0)
            sum += j;
    }
    if (sum == num)
        return true;
    return false;
}
int main()
{
    int end_of_range;
    cout << "give end of range: ";
    cin >> end_of_range;
    for (int i = 1 ; i<end_of_range ; i++)
    {
        if (perfect_checker(i))
            cout << i << endl;
    }
}
