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
        cout << "\nÊîíñòðóêòîð èíèöèàëèçàöèè âûçâàí.\n";
    }

    Paral() : m_height(1.3f), m_length(2.2f), m_width(7.1f)        // Êîíñòðóêòîð áåç ïàðàìåòðîâ
    {
        cout << "\nÊîíñòðóêòîð áåç ïàðàìåòðîâ âûçâàí.\n";
    }

    Paral(const Paral& other) : m_height(other.m_height), m_length(other.m_length), m_width(other.m_width)
    {
        cout << "\nÊîíñòðóêòîð êîïèðîâàíèÿ âûçâàí.\n";
    }

    ~Paral() {
        cout << "\nÄåñòðóêòîð îáúåêòà âûçâàí.\n";
    }

    float find_square() {
        float m_square = 2 * m_length * m_width + 2 * m_width * m_height + 2 * m_length * m_height;
        cout << "\nÏëîùàäü ïîâåðõíîñòè ðàâíà: " << m_square << " ñì3.\n";
        return m_square;
    }
    float find_edge_sum() {
        float m_edges_sum = 4 * (m_height + m_length + m_width);
        cout << "\nÑóììà âñåõ ðåáåð ðàâíà: " << m_edges_sum << " ñì3.\n";
        return m_edges_sum;
    }


};


void info_view(Paral& figure)
{
    cout <<"\nÎáúåêò êëàññà Paral:"
        << "\nÂûñîòà ðàâíà: " << figure.m_height << " ñì."
        << "\nÄëèíà ðàâíà: " << figure.m_length << " ñì."
        << "\nØèðèòà ðàâíà: " << figure.m_width << " ñì.\n";
}



int main() {
    setlocale(LC_ALL, "Russian"); 

    // Ñîçäàíèå òðåõ îáúåêòîâ
    Paral object1;
    Paral object2(5.0f, 5.0f, 5.0f);
    Paral object3(object1);

    // Óêàçàòåëè íà îáúåêòû
    Paral* pointer1 = &object1;
    Paral* pointer2 = &object2;
    Paral* pointer3 = &object3;

    // Ôóíêöèÿ èíôîðìàöèè îáúåêòà
    info_view(object1);
    info_view(object2);
    info_view(object3);

    // Ìåòîäû îáúåêòîâ
    object1.find_edge_sum();
    object1.find_square();

    object2.find_edge_sum();
    object2.find_square();

    object3.find_edge_sum();
    object3.find_square();

    // Äîñòóï ê ïîëÿì êëàññà
    object1.m_height = 3.4f;
    object2.m_length = 3.4f;
    object3.m_width = 3.4f;


    return 0;
}
