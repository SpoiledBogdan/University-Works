#include <iostream>
using namespace std;

class University {
public:
	string name_university; 	//Название университета 
	float freshman;			//freshman - первокурсник; количество первокурсников 
	float graduate;			//Количество выпускников 
	float Q;			//Качество объекта

	University() {
		name_university = "NULL";
		freshman = 0;
		graduate = 0;
		Q = 0;
	}

	University(string _name_university, float _freshman, float _graduate) {
		name_university = _name_university;
		freshman = _freshman;
		graduate = _graduate;
	}

	virtual void quality() {  //Определяем метод как виртуальный
		Q = graduate / freshman;
		cout << "Отношение Q равно: " << Q << "\n" << endl;
	}

	void University_info() {
		cout << "Название университета: "     << name_university << endl;
		cout << "Количество первокурсников: " << freshman << endl;
		cout << "Количество выпускников: "    << graduate << endl;
	}
};

class University_extend : public University {
public:
	float P;  //Процент выпускников, работающие по специальности 
	float Qp; //Качество объекта 2 уровня

	University_extend() {
		Q = 0;
		P = 0;
		Qp = 0;
	}

	University_extend(string _name_university, float _freshman, float _graduate, float _P) {
		name_university = _name_university;
		freshman = _freshman;
		graduate = _graduate;
		P = _P;
	}

	//Переопределнный метод уже в дочернем классе
	void quality() override {  
		/*override : для точного контроля сигнатуры метода
		Например: нельзя будет написать int quality(), 
		компилятор будет это воспринимать как отдельный метод
		Переопределяемый метод обязан иметь тип возвращаемого значения
		и название таким же, как и у виртуального метода
		*/

		Q = graduate / freshman;
		Qp = P * Q;
		cout << "Отношение Qp равно: " << Qp << "\n" << endl;
	}

	void University_extend_info() {
		cout << "Название университета: " << name_university << endl;
		cout << "Количество первокурсников: " << freshman << endl;
		cout << "Количество выпускников: " << graduate << endl;
		cout << "Процент выпускников, работающие по специальности: " << P << endl;
	}
};

int main() {
	setlocale(LC_ALL, "Russian");

	University technical("BSUT", 100, 200);
	technical.University_info();
	technical.quality();

	University_extend medical("GSMU", 200, 300, 100);
	medical.University_extend_info();
	medical.quality();


	return 0;
}
