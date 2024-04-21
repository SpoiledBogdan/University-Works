#include <iostream>
#include <string>
#include <map>
#include <algorithm>

using namespace std;

int main() {
	setlocale(LC_ALL, "Russian");

	int graduate;
	string name_university;
	map<string, int> university;

	char c = 0;
	int i = 0;

	while (true) {
		cout << "Введите название заведения (ключ) №" << i + 1 << ": ";
		cin >> name_university;
		cout << "Введите количество выпускников (значение) №" << i + 1 << ": ";
		cin >> graduate;
		university.insert(make_pair(name_university, graduate));  //создание пары "ключ-значение"
		i += 1;

		cout << "Продолжить ввод? (0 - да)" << endl;
		cin >> c;
		
		if (c == '0') {
			cin.ignore(256, '\n');
			continue;
		}
		else {
			break;
		}
	};

	map<string, int>::iterator it;      //обьявляем итератор
	it = university.begin();	        //присваеваем ему начальный элемент map'a

	//вывод данных нашего map'a
	while (it != university.end()) {    
		cout << it->first << "(ключ) = " << it->second <<"(значение)" << endl;
		++it;
	}

	it = min_element(university.begin(), university.end());  //поиск минимального элемента в map'e
	cout << "Минимальный элемент равен ";
	cout << it->first << "(ключ) = " << it->second << "(значение)" << endl;

	return 0;
}
