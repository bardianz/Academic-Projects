#include <iostream>

using namespace std;

struct student{
  int score;
  string name;
};

int main()
{
    int number;
    cout << "give me number of students: ";
    cin >> number;

    struct student arr [number];

    for(int i = 0; i<number ; i++){
        int score;
        string name;
        cout << endl <<"input name of student: ";
        cin >> name;
        cout << "input score of student: ";
        cin >> score;

        arr[i].name = name;
        arr[i].score = score;
    }

    cout << endl<<endl;

    for(int i = 0; i<=number ; i++){
        if (arr[i].score >= 10){
            cout << arr[i].name << " passed with " << arr[i].score <<endl;
        }
        else{
            cout << arr[i].name << " rejected with " << arr[i].score <<endl;
        }
    }
    return 0;
}
