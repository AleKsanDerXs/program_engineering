# Makefile для библиотеки

# Переменные
PROJECT_NAME=MathLibrary
LIB_DIR=./lib

# Цель по умолчанию - компиляция библиотеки
compile:
	dotnet build -c Release

# Установка библиотеки в папки lib и include
install: compile
	mkdir -p $(LIB_DIR)
	cp bin/Release/netstandard2.0/$(PROJECT_NAME).dll $(LIB_DIR)

# Удаление установленных файлов
uninstall:
	rm -f $(LIB_DIR)/$(PROJECT_NAME).dll

# Очистка от скомпилированных файлов
clean:
	dotnet clean

# Это для того, чтобы цели не пересекались с именами файлов
.PHONY: compile install uninstall clean
