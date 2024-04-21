#include <iostream>
#include <string>
#include <sstream>
#include <fstream>

using namespace std;

class University {
public:
	string name_university; //Название университета 
	float freshman;			//freshman - первокурсник; количество первокурсников 
	float graduate;			//Количество выпускников 

	University() {
		name_university = "NULL";
		freshman = 0;
		graduate = 0;
	}

	University(string _name_university, float _freshman, float _graduate) {
		name_university = _name_university;
		freshman = _freshman;
		graduate = _graduate;
	}

	float quality() {
		return graduate / freshman;
	}

	void University_info() {
		cout << "Название университета: " << endl;
		cout << "Количество первокурсников: " << freshman << endl;
		cout << "Количество выпускников: " << graduate << endl;
	}
};

class University_extend : public University {
public:
	string name_university;
	float freshman;
	float graduate;
	float P;

	University_extend() {
		freshman = 0;
		graduate = 0;
		P = 0;
	}

	University_extend(string _name_university, float _freshman, float _graduate, float _P) {
		name_university = _name_university;
		freshman = _freshman;
		graduate = _graduate;
		P = _P;
	}

	//Переопределнный метод уже в дочернем классе
	float quality() {
		return University::quality() * P;
	}

	void University_extend_info() {
		cout << "Название университета: " << endl;
		cout << "Количество первокурсников: " << freshman << endl;
		cout << "Количество выпускников: " << graduate << endl;
		cout << "Процент выпускников, работающие по специальности: " << P << endl;
	}
};

int main() {
	setlocale(LC_ALL, "Russian");

	University_extend list[5];
	for (int i = 0; i < 5; i++) {
		cout << "Введите название универститета №" << i + 1 << "\n";
		cin >> list[i].name_university;

		cout << "Введите количество первокурсников №" << i + 1 << "\n";
		cin >> list[i].freshman;

		cout << "Введите количество выпускников №" << i + 1 << "\n";
		cin >> list[i].graduate;

		cout << "Введите процент выпускников, работающие по специальности:  №" << i + 1 << "\n";
		cin >> list[i].P;
	}

	string strlist[5];
	for (int i = 0; i < 5; i++) {
		ostringstream Str;
		Str << list[i].name_university << " " << list[i].freshman << " " << list[i].graduate << " " << list[i].P;
		strlist[i] = Str.str();
	}

	ofstream out;
	out.open("in.txt");
	for (int i = 0; i < 5; i++) {
		out << strlist[i] << endl;
	}


	//Сортировка
	for (int j = 0; j < 16; j++) {
		for (int i = 0; i < 4; i++) {
			if (list[i].name_university > list[i + 1].name_university) {
				swap(strlist[i], strlist[i + 1]);
				swap(list[i], list[i + 1]);
			}
		}
	}

	ofstream out2;
	out2.open("out.txt");
	for (int i = 0; i < 5; i++) {
		out2 << strlist[i] << endl;
	}
	return 0;
}
