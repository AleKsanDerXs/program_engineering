#include <iostream>
#include <vector>
#include <string>
#include <locale>
#include <windows.h>
#include "../TextOperations/Meo.h"

using namespace TextLibrary;


void ClearInput()
{
    std::cin.clear();                 
    std::cin.ignore(10000, '\n');     // Очищаем буфер ввода
}

void Menu()
{
    std::cout << "Программа для работы с котятами\n";
    std::cout << "Выберите операцию:\n";
    std::cout << "add - добавить котика, kill - убрать котика\n";
}

int main()
{   
    std::string cat = "";
    SetConsoleOutputCP(CP_UTF8);
    Menu();
    while (true)
    {

        std::string userInput;
        std::cin >> userInput;

        // Обработка команды --help
        if (userInput == "--help")
        {
            Menu();
            continue;
        }

        if (userInput == "add")
        {
            cat = Meow(cat);
            std::cout << cat << std::endl;
        }

        if (userInput == "kill")
        {
            cat = "";
            std::cout << cat << std::endl;
        }

        if (std::cin.fail())  // Проверяем, произошла ли ошибка ввода
        {
            std::cout << "Неверный ввод.\n";
            ClearInput();
            continue;
        }


        
    }
    return 0;
}
