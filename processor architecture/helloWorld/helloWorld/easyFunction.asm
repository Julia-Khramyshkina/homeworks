; extern "C" int sum(int a, int b)
.CODE ; Начало сегмента кода
sum PROC ; Начало функции sum
add rdx, rcx ; Прибавление регистра RCX к RDX
mov rax, rdx ; Копирование RDX в RAX
ret ; Возврат в главную программу
sum ENDP ; Конец функции sum
END ; Конец текста программы