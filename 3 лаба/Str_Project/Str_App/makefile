# Makefile ��� ���������� Str_App

APP_NAME = App
SRC = App.cpp
OBJ = $(SRC:.cpp=.o)
PREFIX = ../Result

# ���������� ��� �������� ���� � ���������� � ������������ ������
LIB_DIR ?= ../Debug/lib
INCLUDE_DIR ?= ../Debug/include

# ���������� � �����
CXX = g++
CXXFLAGS = -std=c++11 -I$(INCLUDE_DIR)
LDFLAGS = -L$(LIB_DIR) -lLibrary -Wl,-rpath,$(LIB_DIR)

# ������� �� ���������: ����������
compile: $(APP_NAME)

$(APP_NAME): $(OBJ)
	$(CXX) $(CXXFLAGS) $^ -o $@ $(LDFLAGS)

%.o: %.cpp
	$(CXX) $(CXXFLAGS) -c $< -o $@

# ���������
install: $(APP_NAME)
	mkdir -p $(PREFIX)/
	cp $(APP_NAME) $(PREFIX)/
	cp $(LIB_DIR)/Library.dll $(PREFIX)/

# �������
clean:
	rm -f $(OBJ) $(APP_NAME)

# �������� �������������� ����������
uninstall:
	rm -f $(PREFIX)/bin/$(APP_NAME)
