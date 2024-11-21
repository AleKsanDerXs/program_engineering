cmake_minimum_required(VERSION 3.12)

# Название проекта
project(Str_Project)

# Установка пути для установки файлов
set(CMAKE_INSTALL_PREFIX ${CMAKE_BINARY_DIR}/install)

# Подключение подпроектов
add_subdirectory(TextOperations)
add_subdirectory(Str_App)
