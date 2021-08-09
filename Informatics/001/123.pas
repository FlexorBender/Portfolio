var
  a:array[char] of integer;
  c,m:char;
  i:integer;
  fin,fout:text;
begin
  assign(fin,'test.txt'); 
  reset(fin);
  assign(fout,'testout.txt');
  rewrite(fout);
  while not eof(fin) do begin
    for c:='A' to 'Z' do a[c]:=0;
    while not eoln(fin)do begin
      read(fin,c);
      inc(a[upcase(c)]);
    end;
    i:=0;
    for c:='A' to 'Z' do  
      if (i=0) or ((i>a[c]) and (a[c]<>0)) then begin m:=c;i:=a[c];end;
    if i>0 then writeln(fout,m,#32,a[m]) else writeln(fout,'Нет английских букв');
    readln(fin);
  end;
  close(fin);
  close(fout);
end.