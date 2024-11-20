# Минимальная версия CMake
cmake_minimum_required(VERSION 3.12)

# Название проекта
project(TextOperations)

# Создание библиотеки
add_library(Library SHARED Library.cpp)

# Установка заголовочного файла и DLL
install(TARGETS Library
    RUNTIME DESTINATION lib
    LIBRARY DESTINATION lib
    ARCHIVE DESTINATION lib
)
install(FILES Meo.h DESTINATION include)
