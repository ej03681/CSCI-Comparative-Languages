#include <iostream>
#include <string>
using namespace std;

int count(const string& s, char a, int high) {
	if (high >= 0)
		return count(s, a, high - 1) + ((s[high]) == a) ? 1 : 0;
	else
		return 0;
}
int count(const string& s, char a) {
	return count(s, a, s.size);
}

int main() {
	string s;
	char ch;
	cout << "Enter a string";
	cin >> s;
	cout << "Enter a character: ";
	cin >> ch;
	cout << ch << "appears " << count(s, ch) << "time in " << s << endl;


	return 0;
}