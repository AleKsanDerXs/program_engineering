# ����������� ������ CMake
cmake_minimum_required(VERSION 3.12)

# �������� �������
project(TextOperations)

# �������� ����������
add_library(Library SHARED Library.cpp)

# ��������� ������������� ����� � DLL
install(TARGETS Library
    RUNTIME DESTINATION lib
    LIBRARY DESTINATION lib
    ARCHIVE DESTINATION lib
)
install(FILES Meo.h DESTINATION include)
