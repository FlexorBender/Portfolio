Program Text files;

Type mas =array ['a'..'z'] of integer;
procedure task;

begin
  writeln('Требуется написать программу, которая будет проводить частотный анализ текста и последовательно');
  writeln('выводить в результирующий файл только букву и через пробел символ * в количестве, равном количеству ');
  writeln('повторений этой буквы в тексте (в каждой строке результирующего файла информация об одной букве,');
  writeln('другие символы  не учитываются). Сведения о буквах, которые в тексте отсутствуют, на экран');
  writeln('выводиться не должны. Сами буквы должны выводиться в алфавитном порядке.');
end;
b
procedure alg (s:string; var res: string);
var g,h,i, l, fp, lp, p: integer; c: char; str: string;m:mas;
begin
i:=1; l:=length(s); str:='';
while i<=l-2 do begin
fp:=i;
if ((s[fp]=s[fp+1]) and (s[fp+1]=s[fp+2]))
then begin m[s[fp]]:=1;
lp:=fp+2;
end
else
lp:=fp;
i:=lp+1;
end;
for c:='a' to 'z' do
if m[c]=1
then str:=str+c;
res:=str;
end;

procedure fileToFile (var f1,f2: text);
var s, res: string; i:integer;
begin
reset(f1); rewrite (f2);
while not eof(f1) do begin
res:='';
readln(f1,s);
if s<>'' then begin
for i:=1 to length(s) do
if s[i] in ['A' .. 'Z']
then s[i]:=chr(ord(s[i])+32);
alg (s, res);
end;
writeln(f2, res);
end;
close (f1); close (f2);
end;
var f1, f2: text; fname1, fname2: string;
begin
writeln ('Введите имя исходного файла');
readln (fname1);
if fileexists (fname1) then begin
writeln ('Введите имя результирующего файла');
readln (fname2);
assign (f1, fname1);
assign (f2, fname2);
fileToFile (f1,f2);
writeln('Задание выполнено');
end
else writeln ('Такого файла не существует');
end.