#include "Meo.h"
#include <fstream>
#include <sstream>
#include <algorithm>
#include <iostream>

namespace TextLibrary
{

    std::string Meow(const std::string& str) 
    {
        // Создаем новую строку, добавляя к входной строке " ^..^ "
        std::string result = str + " ^..^ ";
        return result;
    }
}
