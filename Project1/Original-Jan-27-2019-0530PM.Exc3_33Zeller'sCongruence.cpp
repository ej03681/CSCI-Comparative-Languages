#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

int main() {
	int q, m, j, k, y;
	string days[7] = {"Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
	
	cout << "Enter year: ";
	cin >> y;
	cout << "Enter month: 1-12: ";
	cin >> m;
	cout << "Enter the day of the month: 1-31: ";
	cin >> q;

	if (m == 1) {
		m = 13;
		y = y - 1;
	}
	if (m == 2) {
		m = 14;
		y = y - 1;
	}
	j = y / 100;
	k = y % 100;
	int h = (q + (26 * (m + 1) / 10) + k + (k / 4) + (j / 4) + 5 * j) % 7;

	cout << "The day of the week is " << h << endl;

	return 0;
}