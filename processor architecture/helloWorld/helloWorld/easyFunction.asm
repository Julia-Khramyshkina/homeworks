; extern "C" int sum(int a, int b)
.CODE ; ������ �������� ����
sum PROC ; ������ ������� sum
add rdx, rcx ; ����������� �������� RCX � RDX
mov rax, rdx ; ����������� RDX � RAX
ret ; ������� � ������� ���������
sum ENDP ; ����� ������� sum
END ; ����� ������ ���������