cmake_minimum_required(VERSION 3.12)

# �������� �������
project(Str_Project)

# ��������� ���� ��� ��������� ������
set(CMAKE_INSTALL_PREFIX ${CMAKE_BINARY_DIR}/install)

# ����������� �����������
add_subdirectory(TextOperations)
add_subdirectory(Str_App)
