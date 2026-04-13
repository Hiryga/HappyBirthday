#include <iostream>
using namespace std;

// ===== 1. ФУНКЦИЯ: вывод ряда Фибоначчи =====
void printFibonacci(int n) {
    setlocale(LC_ALL, "Russian");
    int a = 0, b = 1;          // первые два числа ряда
    cout << "Фибоначчи: ";
    for (int i = 0; i < n; i++) {
        cout << a << " ";      // выводим текущее
        int c = a + b;         // следующее = сумма двух предыдущих
        a = b;                 // сдвигаем
        b = c;
    }
    cout << endl << endl;
}

// ===== 2. СТРУКТУРА =====
struct Point {
    int x;
    int y;
};

// ===== 3. КЛАСС (простая матрица 2x2) =====
class Matrix2x2 {
public:
    int m[2][2]; // просто массив 2x2

    void fill() {
        cout << "Ввод 2x2 матрицы:" << endl;
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                cout << "m[" << i << "][" << j << "] = ";
                cin >> m[i][j];
            }
        }
    }

    void print() {
        cout << "Матрица:" << endl;
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                cout << m[i][j] << " ";
            }
            cout << endl;
        }
        cout << endl;
    }
};

// ===== 4. ФУНКЦИЯ: пузырьковая сортировка (самая простая) =====
void bubbleSort(int arr[], int size) {
    // простой алгоритм: проходим по массиву и меняем местами, если порядок неправильный
    for (int i = 0; i < size - 1; i++) {
        for (int j = 0; j < size - 1 - i; j++) {
            if (arr[j] > arr[j + 1]) {
                // меняем элементы местами
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

// ===== 5. main: всё вместе =====
int main() {
    // --- ФИБОНАЧЧИ (ряд) ---
    printFibonacci(10); // вывод первых 10 чисел Фибоначчи

    // --- СТРУКТУРА Point ---
    Point p;
    p.x = 3;
    p.y = 5;
    cout << "Точка p: x = " << p.x << ", y = " << p.y << endl << endl;

    // --- КЛАСС Matrix2x2 ---
    Matrix2x2 mat;
    mat.fill();   // вводим элементы с клавиатуры
    mat.print();  // выводим

    // --- МАССИВ + СОРТИРОВКА ---
    int arr[5] = { 5, 2, 4, 1, 3 };
    cout << "Массив до сортировки: ";
    for (int i = 0; i < 5; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    bubbleSort(arr, 5); // сортируем

    cout << "Массив после сортировки (bubble sort): ";
    for (int i = 0; i < 5; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    return 0;
}