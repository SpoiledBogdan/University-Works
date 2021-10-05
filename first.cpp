#include <iostream>
#include <conio.h>

using namespace std;

class Paral {
public:
    float m_height;
    float m_length;
    float m_width;


    Paral(float height, float length, float width) {
        m_height = height;
        m_length = length;
        m_width = width;
        cout << "\nКонструктор инициализации вызван.\n";
    }

    Paral() : m_height(1.3f), m_length(2.2f), m_width(7.1f)        // Конструктор без параметров
    {
        cout << "\nКонструктор без параметров вызван.\n";
    }

    Paral(const Paral& other) : m_height(other.m_height), m_length(other.m_length), m_width(other.m_width)
    {
        cout << "\nКонструктор копирования вызван.\n";
    }

    ~Paral() {
        cout << "\nДеструктор объекта вызван.\n";
    }

    float find_square() {
        float m_square = 2 * m_length * m_width + 2 * m_width * m_height + 2 * m_length * m_height;
        cout << "\nПлощадь поверхности равна: " << m_square << " см3.\n";
        return m_square;
    }
    float find_edge_sum() {
        float m_edges_sum = 4 * (m_height + m_length + m_width);
        cout << "\nСумма всех ребер равна: " << m_edges_sum << " см3.\n";
        return m_edges_sum;
    }


};


void info_view(Paral& figure)
{
    cout <<"\nОбъект класса Paral:"
        << "\nВысота равна: " << figure.m_height << " см."
        << "\nДлина равна: " << figure.m_length << " см."
        << "\nШирита равна: " << figure.m_width << " см.\n";
}



int main() {
    setlocale(LC_ALL, "Russian");

    // Создание трех объектов
    Paral object1;
    Paral object2(5.0f, 5.0f, 5.0f);
    Paral object3(object1);

    // Указатели на объекты
    Paral* pointer1 = &object1;
    Paral* pointer2 = &object2;
    Paral* pointer3 = &object3;

    // Функция информации объекта
    info_view(object1);
    info_view(object2);
    info_view(object3);

    // Методы объектов
    object1.find_edge_sum();
    object1.find_square();

    object2.find_edge_sum();
    object2.find_square();

    object3.find_edge_sum();
    object3.find_square();

    // Доступ к полям класса
    object1.m_height = 3.4f;
    object2.m_length = 3.4f;
    object3.m_width = 3.4f;


    return 0;
}
