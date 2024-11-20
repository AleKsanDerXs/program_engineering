# Makefile для приложения Str_App

APP_NAME = App
SRC = App.cpp
OBJ = $(SRC:.cpp=.o)
PREFIX = ../Result

# Переменная для указания пути к библиотеке и заголовочным файлам
LIB_DIR ?= ../Debug/lib
INCLUDE_DIR ?= ../Debug/include

# Компилятор и флаги
CXX = g++
CXXFLAGS = -std=c++11 -I$(INCLUDE_DIR)
LDFLAGS = -L$(LIB_DIR) -lLibrary -Wl,-rpath,$(LIB_DIR)

# Правило по умолчанию: компиляция
compile: $(APP_NAME)

$(APP_NAME): $(OBJ)
	$(CXX) $(CXXFLAGS) $^ -o $@ $(LDFLAGS)

%.o: %.cpp
	$(CXX) $(CXXFLAGS) -c $< -o $@

# Установка
install: $(APP_NAME)
	mkdir -p $(PREFIX)/
	cp $(APP_NAME) $(PREFIX)/
	cp $(LIB_DIR)/Library.dll $(PREFIX)/

# Очистка
clean:
	rm -f $(OBJ) $(APP_NAME)

# Удаление установленного приложения
uninstall:
	rm -f $(PREFIX)/bin/$(APP_NAME)
