# Минимальная версия CMake
cmake_minimum_required(VERSION 3.12)

# Название проекта
project(Str_App)

# Указываем путь к заголовочным файлам и библиотеке
include_directories(${CMAKE_SOURCE_DIR}/TextOperations)
link_directories(${CMAKE_BINARY_DIR}/TextOperations)

# Создание исполняемого файла
add_executable(App App.cpp)

# Линковка с библиотекой TextOperations
target_link_libraries(App Library)

# Установка исполняемого файла
install(TARGETS App
    RUNTIME DESTINATION bin
)

