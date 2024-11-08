# Makefile для консольного приложения

# Переменные
CC = dotnet
APP = ConsoleApp.exe
SRC = Program.cs
LIB_DIR = ../MathLibrary/lib
LIBRARY = $(LIB_DIR)/MatrixLibrary.dll
DEST_DIR = d/Прогер проекты/Балабасова/2 лаба/ConsoleApp/bin/Release100


# Цель по умолчанию - компиляция приложения
compile: $(SRC)
#	$(CC) -reference:$(LIBRARY) -out:$(APP) $(SRC)
	dotnet build $(PROJECT_DIR)
	
# Установка приложения в заданную папку
install: $(APP)
	mkdir -p $(DEST_DIR)
	cp $(APP) $(DEST_DIR)

# Удаление установленного приложения
uninstall: 
	rm -f $(DEST_DIR)/$(APP)

# Очистка от скомпилированных файлов
clean:
	rm -f $(APP)

# Чтобы цели не пересекались с именами файлов
.PHONY: compile install uninstall clean
