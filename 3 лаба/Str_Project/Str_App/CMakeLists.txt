# ����������� ������ CMake
cmake_minimum_required(VERSION 3.12)

# �������� �������
project(Str_App)

# ��������� ���� � ������������ ������ � ����������
include_directories(${CMAKE_SOURCE_DIR}/TextOperations)
link_directories(${CMAKE_BINARY_DIR}/TextOperations)

# �������� ������������ �����
add_executable(App App.cpp)

# �������� � ����������� TextOperations
target_link_libraries(App Library)

# ��������� ������������ �����
install(TARGETS App
    RUNTIME DESTINATION bin
)

