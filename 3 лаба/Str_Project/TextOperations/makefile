# Makefile ��� ���������� TextOperations

LIB_NAME = Library.dll
LIB_IMPLIB = Library.lib
SRC = Library.cpp
OBJ = $(SRC:.cpp=.o)

# ���� ��� ���������
PREFIX ?= ../Debug
LIB_INSTALL_DIR = $(PREFIX)/lib
INCLUDE_INSTALL_DIR = $(PREFIX)/include

# ���������� � �����
CXX = g++
CXXFLAGS = -std=c++11 -fPIC -DTEXT_OPERATIONS_EXPORTS -I.

# ������� �� ���������: ����������
compile: $(LIB_NAME)

$(LIB_NAME): $(OBJ)
	$(CXX) $(CXXFLAGS) -shared -o $@ $^ -Wl,--out-implib,Library.lib

%.o: %.cpp
	$(CXX) $(CXXFLAGS) -c $< -o $@

# ��������� ���������� � ������������� �����
install: $(LIB_NAME)
	mkdir -p $(LIB_INSTALL_DIR)
	mkdir -p $(INCLUDE_INSTALL_DIR)
	cp $(LIB_NAME) $(LIB_INSTALL_DIR)/
	cp $(LIB_IMPLIB) $(LIB_INSTALL_DIR)/
	cp Meo.h $(INCLUDE_INSTALL_DIR)/

# �������
clean:
	rm -f $(OBJ) $(LIB_NAME) $(LIB_IMPLIB)

# �������� ������������� ����������
uninstall:
	rm -f $(LIB_INSTALL_DIR)/$(LIB_NAME)
	rm -f $(LIB_INSTALL_DIR)/$(LIB_IMPLIB)
	rm -f $(INCLUDE_INSTALL_DIR)/Meo.h
